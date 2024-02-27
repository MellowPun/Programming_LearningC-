using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Letter : Mail
    {
        protected string _Text;
        public Letter(Address adress,string text) : base(adress)
        {
            _Text = text;
        }

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public override string ShowContent()
        {

            return base.ShowContent() + string.Format("\nText: {0}.\n",_Text);
        }

        public override string GetMailType()
        {
            return string.Format("Letter");
        }




    }
}
