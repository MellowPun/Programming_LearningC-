using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    
    internal class OEF8
    {

        protected string mName;
        protected double mPoints;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public double Points
        {
            get { return mPoints; }
            set { mPoints = value; }

        }

        public override string ToString()
        {
            string result = string.Format("{0} has {1}%",Name,Points.ToString("#0.0"));

            return result;
        }

    }
}
