using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAdll
{
    public class AALooseItem : AAStockItem
    {
        private bool _IsSquashable;

        public AALooseItem(string brand, ItemType type, bool isSquashable ) : base(brand, type)
        {
            
        }

    }
}
