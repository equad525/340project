using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.PD
{
    public class FixedFee
    {
        public string FeeName { get; set; }
        public double Fee { get; set; }

        public FixedFee() { }
        public FixedFee(string feeName, double fee) 
        {
            this.FeeName = feeName;
            this.Fee = fee;
        }
    }
}
