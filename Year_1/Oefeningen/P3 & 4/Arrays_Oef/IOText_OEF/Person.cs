using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace IOText_OEF
{
    [Serializable]
    internal class Person
    {
        protected string mName;
        protected int mAge;
        protected string mHairColor;
        protected string mCity ;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Age
        {
            get { return mAge; }
            set { mAge = value; }

        }

        public string HairColor
        {
            get { return mHairColor; }
            set { mHairColor = value; }

        }
        public string City
        {
            get { return mCity; }
            set { mCity = value; }

        }

    


    }
}
