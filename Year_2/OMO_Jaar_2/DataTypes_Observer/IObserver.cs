using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Observer
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
