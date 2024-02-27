using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{

    public enum Grade
    {
        failed,
        sufficient,
        distinction,
        great_distinction,
        greatest_distinction
    }

    internal class OEF9
    {
        protected string mName;
        protected double mPoints;

        public OEF9(string name, double points) 
        {
            mName = name;
            mPoints = points;

        }

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

        private Grade GetGrade()
        {
            if (mPoints <50)
            {
                return Grade.failed ; 
            }
            if(50 <= mPoints && mPoints < 68)
            {
                return Grade.sufficient ;   
            }
            if (69 <= mPoints && mPoints < 75)
            {
                return Grade.distinction;
            }
            if (76 <= mPoints && mPoints < 85)
            {
                return Grade.great_distinction;
            }
            else
            {
                return Grade.greatest_distinction;
            }
        }

        public bool IsFailed()
        {
            if (mPoints < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0} has {1}% {2}", Name, Points.ToString("#0.0"), GetGrade());

            return result;
        }

    }
}
