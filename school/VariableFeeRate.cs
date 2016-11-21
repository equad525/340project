using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VariableFeeRate
    {
        private string _studentType;
        private string _inOrOutOfState;
        private decimal _fee;

        public VariableFeeRate() { }

        public VariableFeeRate(string studentType, string inOrOutOfState, decimal fee)
        {
            SType = studentType;
            InOrOutOfState = inOrOutOfState;
            Fee = fee;
        }

        #region Properties
        public string SType
        {
            get { return _studentType; }
            set { _studentType = value; }
        }

        public string InOrOutOfState
        {
            get { return _inOrOutOfState; }
            set { _inOrOutOfState = value; }
        }

        public decimal Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }
        #endregion
    }
}
