using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Mail
    {
        protected Address _Address;

        public Mail(Address sender) { _Address = sender; }

        public Address Sender
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public virtual string ShowContent()
        {
            return string.Format("Sender: {0}. ",_Address.GetDescription());

        }
        public virtual string GetMailType()
        {
            return string.Format("");
        }

    }
}
