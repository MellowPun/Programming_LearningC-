using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Package: Mail
    {
        protected int _Weight;
        protected string _Content;

        public Package(Address adress, int weight, string content) : base(adress)
        {
            _Weight = weight;
            _Content = content;
        }

        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
        public override string ShowContent()
        {

            return base.ShowContent() + string.Format("\nWeight: {0} kg. \nContent: {1}.\n",_Weight,_Content);
            
        }
        public override string GetMailType()
        {
            return string.Format("Package");
        }

    }
}
