using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections.ObjectModel;
using school;

namespace Data
{
    public static class DataAccess
    {
        private static string _connectionString;
        private static Stack<string> _errors;

        static DataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["cis340"].ConnectionString;
            _errors = new Stack<string>();
        }

        #region CRUD Methods
        /// <summary>
        /// Retrieve a list of objects from the Database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="conditions">conditions by which to filter returned objects (will return all rows if not specified)</param>
        /// <param name="selectFields">Specifiy which fields to be populated on returned objects (will select all fields if not specified. Spelling matters!)</param>
        /// <param name="orderBy">Specify the order of the list and by which fields (defaults to Ascending)</param>
        /// <returns></returns>
        public static List<T> Retrieve<T>(IEnumerable<Condition> conditions = null, string[] selectFields = null, OrderBy orderBy = null)
        {
            Type type = typeof(T);
            List<T> list = new List<T>();
            string query = QueryBuilder.BuildQuery<T>(QueryBuilder.QueryTypes.Retrieve, conditions, selectFields, orderBy: orderBy);

            using(SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object instance = Activator.CreateInstance(typeof(T));

                            if (selectFields != null)
                            {
                                foreach (string f in selectFields)
                                {
                                    try
                                    {
                                        PropertyInfo prop = type.GetProperty(f.Capitalize());
                                        prop.SetValue(instance, reader[f.DeCapitalize()]);
                                    }
                                    catch (Exception e)
                                    {
                                        PushError(e);
                                    }
                                }
                            }
                            else
                            {
                                PropertyInfo[] props = QueryBuilder.GetTypeProperties(type);
                                foreach (PropertyInfo p in props)
                                {
                                    try
                                    {
                                        p.SetValue(instance, reader[p.Name.DeCapitalize()]);
                                    }
                                    catch (Exception e)
                                    {
                                        PushError(e);
                                    }
                                }
                            }

                            list.Add((T)instance);
                        }
                    }
                }
                catch ( Exception e )
                {
                    PushError(e);
                }
            }

            return list;
        }

        /// <summary>
        /// Update exisiting object in the database. If you do not specifiy the conditions parameter, ALL rows in the table will be updated!
        /// </summary>
        /// <typeparam name="T">Type of object being saved</typeparam>
        /// <param name="objToSave">The object with the values to be updated</param>
        /// <param name="primaryKeyField">Specify the Primary Key so it doesn't accidentally update (still testing if this is required)</param>
        /// <param name="conditions">Conditions to filter rows to be updated (all ROWS will update if conditions are not specified!)</param>
        /// <param name="updateFields">Specific fields to update (all FIELDS will be updated if not specified)</param>
        /// <returns></returns>
        public static bool Update<T>(T objToSave, string primaryKeyField = null, IEnumerable<Condition> conditions = null, string[] updateFields = null)
        {
            if(objToSave == null)
            {
                PushError("Non-Null Object must be passed into Update method");
                return false;
            }
            string query = QueryBuilder.BuildQuery<T>(QueryBuilder.QueryTypes.Update, conditions: conditions, updateObj: objToSave, primaryKeyField: primaryKeyField);

            return ExecuteSQLCommand(query);
        }

        /// <summary>
        /// Inserts an object as a row into the Database
        /// </summary>
        /// <typeparam name="T">Type of object being inserted</typeparam>
        /// <param name="objToCreate">Object you want to insert</param>
        /// <param name="primaryKeyField">In the case of an Auto-Incrementing primary key, specifiy it here so it's not touched</param>
        /// <returns></returns>
        public static bool Create<T>(T objToCreate, string primaryKeyField = null)
        {
            if(objToCreate == null)
            {
                PushError("Non-Null Object must be passed into the Create method");
                return false;
            }

            string query = QueryBuilder.BuildQuery<T>(QueryBuilder.QueryTypes.Create, primaryKeyField: primaryKeyField, insertObj: objToCreate);

            return ExecuteSQLCommand(query);
        }

        /// <summary>
        /// Delete rows from the Database. IF YOU DON'T SPECIFY WHERE CONDITIONS, ALL ROWS WILL BE DELETED!!
        /// </summary>
        /// <typeparam name="T">The Type to Delete</typeparam>
        /// <param name="conditions">Conditions to specify which rows to delete. IF YOU DON'T PASS CONDITIONS, ALL ROWS FOR THE TYPE WILL BE REMOVED!!</param>
        /// <returns></returns>
        public static bool Delete<T>(IEnumerable<Condition> conditions = null)
        {
            string query = QueryBuilder.BuildQuery<T>(QueryBuilder.QueryTypes.Delete, conditions);

            return ExecuteSQLCommand(query);
        }
        #endregion

        #region Misc
        public static bool TestConnection()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                PushError(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Execute a custom Sql Command
        /// </summary>
        /// <param name="query">The query string to execute</param>
        /// <returns>Returns a bool indicating failure/success. Does not return results from SELECT statements.</returns>
        public static bool ExecuteSQLCommand(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                PushError(e);
                return false;
            }

            return true;
        }

        public static string TryLogin(string password, string username)
        {
            string login = "Null";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand com = new SqlCommand("SELECT sid, password  FROM students WHERE sid = @sid AND password = @password", conn);
                    com.Parameters.AddWithValue("@sid", username);
                    com.Parameters.AddWithValue("@password", password);
                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();


                    if (reader != null && reader.Read())
                    {
                        login = "Student";

                    }
                    else if (reader == null)
                    {
                        reader.Close();
                        com = new SqlCommand("SELECT tid, password, staffType FROM staff WHERE tid = @tid AND password = @password", conn);
                        com.Parameters.AddWithValue("@tid", username);
                        com.Parameters.AddWithValue("@password", password);
                        conn.Open();
                        reader = com.ExecuteReader();
                        if (reader != null && reader.Read())
                        {
                            if (reader["staffType"].ToString().Equals("DEPARTMENT"))
                                login = "DepartmentStaff";
                            else
                                login = "RegistrarStaff";
                        }
                    }
                    else
                    {
                        login = "Null";
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return login;
        }

        public static string DeCapitalize(this String str)
        {
            return Char.ToLowerInvariant(str[0]) + str.Substring(1);
        }

        public static string Capitalize(this String str)
        {
            return Char.ToUpperInvariant(str[0]) + str.Substring(1);
        }

        public static void ClearErrors()
        {
            _errors.Clear();
        }

        private static void PushError(Exception e)
        {
            Errors.Push($"{e.Message} : {e.Source}");
        }

        private static void PushError(string msg)
        {
            Errors.Push(msg);
        }
        #endregion

        #region Nested Classes
        /// <summary>
        /// Class Representing WHERE Condition for SQL
        /// </summary>
        public class Condition
        {
            private string _left;
            private string _right;
            private Operators _conditionOperator;

            public Condition() { }

            /// <summary>
            /// Class Representing WHERE Condition for SQL
            /// </summary>
            /// <param name="left">DB Column</param>
            /// <param name="conditionOperator">Operator for comparing the Left and Right Field</param>
            /// <param name="right">Value used to compare against the Left Field</param>
            public Condition(string left, Operators conditionOperator, string right)
            {
                Left = left;
                Right = right;
                ConditionOperator = conditionOperator;
            }

            #region Props
            /// <summary>
            /// The Left field which will be the DB column to check
            /// </summary>
            public string Left
            {
                get { return _left; }
                set { _left = value; }
            }

            /// <summary>
            /// The Right field which will be the value to compare the Left field against
            /// </summary>
            public string Right
            {
                get { return _right; }
                set { _right = value; }
            }

            /// <summary>
            /// The operator which determines which type of check to perform between the Left & Right fields
            /// </summary>
            public Operators ConditionOperator
            {
                get { return _conditionOperator; }
                set { _conditionOperator = value; }
            }
            #endregion

            public enum Operators
            {
                Equal,
                NotEqual,
                Greater,
                Lesser,
                GreaterEquals,
                LesserEquals
            }
        }

        /// <summary>
        /// Class representing a list of Conditions
        /// </summary>
        public class ConditionList : Collection<Condition>
        {
            private Operators _operator;

            public ConditionList() { }

            /// <summary>
            /// Class representing a list of Conditions
            /// </summary>
            /// <param name="conditions">An Enumerable list of conditions</param>
            /// <param name="op">The operator for the conditions ('AND', or 'OR')</param>
            public ConditionList(List<Condition> conditions, Operators op)
            {
                Conditions = conditions;
                Operator = op;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="op">The operator for the conditions ('AND', or 'OR')</param>
            /// <param name="conditions">Conditions to add to the list (1 or more)</param>
            public ConditionList(Operators op, params Condition[] conditions)
            {
                Operator = op;
                Conditions = conditions.ToList();
            }

            public enum Operators
            {
                And,
                Or
            }

            public List<Condition> Conditions
            {
                get { return Items.ToList(); }
                set
                {
                    Items.Clear();
                    foreach(Condition c in value)
                    {
                        Items.Add(c);
                    }
                }
            }

            public Operators Operator
            {
                get { return _operator; }
                set { _operator = value; }
            }

            public new Condition this[int index]
            {
                get { return Conditions[index]; }
            }
        }

        public class OrderBy
        {
            private string[] _fields;
            private Order _order;

            public OrderBy() { }

            /// <summary>
            /// Represents the Order By clause in SQL
            /// </summary>
            /// <param name="fields">Fields to order by</param>
            /// <param name="order">Ascending or Descending order</param>
            public OrderBy(string[] fields, Order order = Order.Ascending)
            {
                Fields = fields;
                OrderValue = order;
            }

            public enum Order
            {
                Ascending,
                Descending
            }

            #region Props
            public string[] Fields
            {
                get { return _fields; }
                set { _fields = value; }
            }

            public Order OrderValue
            {
                get { return _order; }
                set { _order = value; }
            }
            #endregion
        }

        private static class QueryBuilder
        {
            public enum QueryTypes
            {
                Create,
                Retrieve,
                Update,
                Delete
            }

            public static string BuildQuery<T>(QueryTypes queryType, IEnumerable<Condition> conditions = null, string[] selectFields = null, string[] updateFields = null, string primaryKeyField = null,
                object updateObj = null, object insertObj = null, OrderBy orderBy = null)
            {
                StringBuilder query = new StringBuilder();
                Type type = typeof(T);

                //PropertyInfo[] props = GetTypeProperties(type);

                query.Append(GetCRUDString(queryType, selectFields) + "\n");
                query.Append(GetFROMString(queryType, type) + "\n");
                if (queryType == QueryTypes.Create)
                    query.Append(GetVALUESString(insertObj, primaryKeyField) + "\n");
                if (queryType == QueryTypes.Update && updateObj != null)
                    query.Append(GetSETString(type, updateObj, updateFields, primaryKeyField) + "\n");
                if (conditions != null && queryType != QueryTypes.Create)
                    query.Append(GetWHEREString(queryType, conditions) + "\n");
                if (orderBy != null && queryType == QueryTypes.Retrieve)
                    query.Append(GetORDERBYString(orderBy));

                return query.ToString();
            }

            private static string GetORDERBYString(OrderBy ob)
            {
                StringBuilder orderClause = new StringBuilder();

                orderClause.Append("ORDER BY ");

                foreach(string o in ob.Fields)
                {
                    orderClause.Append($"{o},");
                }

                orderClause.Remove(orderClause.Length - 1, 1);

                orderClause.Append($" {GetOrderByFromEnum(ob.OrderValue)}");

                return orderClause.ToString();
            }

            private static string GetWHEREString(QueryTypes queryType, IEnumerable<Condition> conditions)
            {
                StringBuilder whereClause = new StringBuilder();
                int characterDelete = 5;
                string op = "AND";

                whereClause.Append("WHERE ");

                if (typeof(ConditionList).IsAssignableFrom(conditions.GetType()))
                {
                    ConditionList conditionList = (ConditionList)conditions;
                    op = GetConditionListOperator(conditionList.Operator);

                    if (op == "OR") characterDelete = 4;
                }

                foreach (Condition condition in conditions)
                {
                    whereClause.Append($"{condition.Left}{GetConditionOperator(condition.ConditionOperator)}'{condition.Right}' {op}\n");
                }

                whereClause.Remove(whereClause.Length - characterDelete, characterDelete);

                return whereClause.ToString();
            }

            private static string GetSETString(Type objectType, object updateObject, string[] updateFields = null, string primaryKeyField = null)
            {
                StringBuilder setClause = new StringBuilder();

                setClause.Append("SET ");

                if(updateFields != null && updateFields.Length > 0)
                {
                    foreach(string u in updateFields)
                    {
                        if (u == primaryKeyField)
                            continue;
                        PropertyInfo prop = objectType.GetProperty(u);
                        setClause.Append($"{u}={GetQueryValue(prop, updateObject)},");
                    }
                }
                else
                {
                    PropertyInfo[] props = GetTypeProperties(objectType);
                    foreach(PropertyInfo p in props)
                    {
                        if (p.Name.DeCapitalize() == primaryKeyField)
                            continue;
                        setClause.Append($"{p.Name.DeCapitalize()}={GetQueryValue(p, updateObject)},");
                    }
                }

                setClause.Remove(setClause.Length - 1, 1);

                return setClause.ToString();
            }

            private static string GetVALUESString(object insertObject, string primaryKeyField = null)
            {
                StringBuilder insertClause = new StringBuilder();
                Type type = insertObject.GetType();

                insertClause.Append("VALUES (");

                PropertyInfo[] props = GetTypeProperties(type);

                foreach(PropertyInfo p in props)
                {
                    if (p.Name.DeCapitalize() == primaryKeyField)
                        continue;
                    insertClause.Append($"{GetQueryValue(p, insertObject)},");
                }

                insertClause.Remove(insertClause.Length - 1, 1);
                insertClause.Append(");");

                return insertClause.ToString();
            }

            private static string GetFROMString(QueryTypes queryType, Type type)
            {
                string standardFrom = "FROM " + type.Name.ToLower();
                switch (queryType)
                {
                    case QueryTypes.Create:
                        return "INTO " + type.Name.ToLower();
                    case QueryTypes.Retrieve:
                        return standardFrom;
                    case QueryTypes.Update:
                        return type.Name.ToLower();
                    case QueryTypes.Delete:
                        return standardFrom;
                    default:
                        return "";
                }
            }

            private static string GetCRUDString(QueryTypes queryType, string[] selectFields = null)
            {
                switch (queryType)
                {
                    case QueryTypes.Create:
                        return "INSERT";
                    case QueryTypes.Retrieve:
                        StringBuilder fields = new StringBuilder();
                        fields.Append("SELECT ");

                        if(selectFields != null)
                        {
                            foreach (string f in selectFields)
                            {
                                fields.Append($"{f},");
                            }
                            fields.Remove(fields.Length - 1, 1);
                        }
                        else
                        {
                            fields.Append("*");
                        }

                        return fields.ToString();
                    case QueryTypes.Update:
                        return "UPDATE";
                    case QueryTypes.Delete:
                        return "DELETE";
                    default:
                        return "";
                }
            }

            private static string GetConditionOperator(Condition.Operators op)
            {
                switch (op)
                {
                    case Condition.Operators.Equal:
                        return "=";
                    case Condition.Operators.NotEqual:
                        return "!=";
                    case Condition.Operators.Greater:
                        return ">";
                    case Condition.Operators.Lesser:
                        return "<";
                    case Condition.Operators.GreaterEquals:
                        return ">=";
                    case Condition.Operators.LesserEquals:
                        return "<=";
                    default:
                        return null;
                }
            }

            private static string GetConditionListOperator(ConditionList.Operators op)
            {
                switch (op)
                {
                    case ConditionList.Operators.And:
                        return "AND";
                    case ConditionList.Operators.Or:
                        return "OR";
                    default:
                        return null;
                }
            }

            private static string GetOrderByFromEnum(OrderBy.Order ob)
            {
                switch (ob)
                {
                    case OrderBy.Order.Ascending:
                        return "ASC";
                    case OrderBy.Order.Descending:
                        return "DESC";
                    default:
                        return null;
                }
            }

            private static string GetQueryValue(PropertyInfo prop, object objectToInsert)
            {
                object value = prop.GetValue(objectToInsert);
                return value.GetType() == typeof(string) ? $"'{value}'" : value.ToString();
            }

            /// <summary>
            /// Return an enumerable Array of PropertyInfo of a given type. Gets only public properties.
            /// </summary>
            /// <param name="type"></param>
            /// <returns>Array of PropertyInfo</returns>
            public static PropertyInfo[] GetTypeProperties(Type type)
            {
                return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            }
        }
        #endregion

        #region Props
        public static Stack<string> Errors
        {
            get { return _errors; }
        }

        public static string LastError
        {
            get
            {
                if (Errors.Count <= 0)
                    return "";
                return Errors.Peek();
            }
        }
        #endregion
    }
}

