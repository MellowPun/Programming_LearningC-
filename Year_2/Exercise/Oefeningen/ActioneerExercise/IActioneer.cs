using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActioneerExercise
{
    public interface IActioneer
    {
        void AttachProduct(IBidders bidder);

        void DetachProduct(IBidders bidder);

        void Notify();
    }
}
