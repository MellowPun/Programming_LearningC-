using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActioneerExercise
{
    public interface IBidders
    {
        void Update(IActioneer products,int price);
    }
}
