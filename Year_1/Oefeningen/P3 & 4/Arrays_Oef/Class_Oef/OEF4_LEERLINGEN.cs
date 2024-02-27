using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class OEF4_LEERLINGEN
    {
        protected string mFirstName;
        protected string mLastName;
        protected ushort mYearOfBirth;

        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }

        }
        public ushort YearOfBirth
        {
            get {return mYearOfBirth; }
            set {mYearOfBirth= value; }
        }

        public string GetFullName()
        {
            string result = string.Format(FirstName + " "+ LastName);
            return result;
        }

        public override string ToString()
        {
            string result = string.Format("First Name: {0}, Last Name: {1}, Fulname: {3}, Birth year: {2}.",FirstName,LastName,YearOfBirth, GetFullName());
            

            return result;
        }

    }
}
