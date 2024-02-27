using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Address
    {
        protected string _Street;
        protected int _StreetNumber;
        protected int _PostCode;
        protected string _City;

        public Address(string street, int number, int postal, string city) 
        {
            _Street = street;
            _StreetNumber = number;
            _PostCode = postal;
            _City = city;

        }
        public string GetDescription()
        {
            return string.Format("{0} {1}, {2} {3}",_Street,_StreetNumber,_PostCode,_City);
        }

    }
}
