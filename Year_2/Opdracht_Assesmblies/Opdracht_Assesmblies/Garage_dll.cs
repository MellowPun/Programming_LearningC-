using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Assesmblies
{
    public class Garage_dll
    {
        protected List<Car_dll> _Cars;
        protected static double _TotalCost=0;
        public Garage_dll( )
        {
            _Cars = new List<Car_dll>();
        }


        public List<Car_dll> Cars
        {
            get { return _Cars; }
            set { _Cars = value; }
        }
        
        public  double TotalCost
        {
            get { return _TotalCost; }
        }
        


        public void AddCar(Car_dll car)
        {
            _Cars.Add(car);
            _TotalCost += car.Price;
        }

        public string FastestCar(List<Car_dll> cars)
        {
            Car_dll winningCar = cars[0];

            for(int i = 1; i < cars.Count; i++)
            {
                if (cars[i].MaxSpeed > winningCar.MaxSpeed)
                {
                    winningCar = cars[i];
                }
                
            }
            return string.Format("The fastest car is {0}", winningCar.Brand);

        }



    }
}
