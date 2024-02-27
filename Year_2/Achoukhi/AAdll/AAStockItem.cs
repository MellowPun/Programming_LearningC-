using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAdll
{
    public enum ItemType
    {
        BoxedItem = 1,
        BaggedItem = 2,
        LooseItem = 3, 
    }
    public class AAStockItem : IStoreable
    {
        private string _Brand;
        private ItemType _Type;

        public string Brand { get { return _Brand; } }

        public ItemType Type { get { return _Type; } }

        public AAStockItem(string brand, ItemType type)
        {
            _Brand = brand;
            _Type = type;
        }

        public string Store()
        {
            switch((int)_Type)
            {
                case 1:
                    return "stacked up";
                    break;

                    case 2:
                    return "on the bag pile";
                    break;

                    case 3:
                    return "on the loose pile";
                    break;

                default:
                    return null;
                    break;


            }
        }

        public override string ToString()
        {
            return string.Format($"{_Brand} - {Store()}");
        }



    }
}
