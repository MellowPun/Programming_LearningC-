using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAdll
{// This exam is made by Achoukhi Ayoub
    public class AAMedium : IShowable
    {
        private string _Medium;
        private bool _IsDigital;

        public bool IsDigital()
        {
            return _IsDigital;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Medium: {_Medium} is digital: {_IsDigital}");
        }

        public AAMedium(string medium, bool isDigital)
        {
            _Medium = medium;
            _IsDigital = isDigital;
        }

    }
}
