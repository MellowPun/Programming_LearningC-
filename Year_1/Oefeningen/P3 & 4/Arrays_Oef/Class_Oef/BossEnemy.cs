using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class BossEnemy
    {
        //public means accessible for every clas
        //protected means that its private and its protected from something else

        protected int mHitPoints;
        protected string mName;
        protected BossEnemy mMinion;
        public int HitPoints
        {
            get { return mHitPoints; }
            set { mHitPoints = CheckForPositiveValue(value); }
        }
        // Set      setting a value into your method
        // Get      getting a value from your method


        public string Name
        {
            get { return mName; }
            set { mName = value; }

        }

        public BossEnemy Minion
        {
            get { return mMinion; }
        }    


        protected int CheckForPositiveValue(int inputValue)
        {
            if (inputValue >= 0)
            {
                return inputValue;
            }
            else
            {
                return 0;
            }
        }

        //Controle van waardes moet je de properties aanroepen niet de achterliggende waarde mHitpoints bij checkvalue

        //als we niet kunnen setten dan kunnen we enkel de achterliggende waarde benoemen
        public void TakeDamage(int damage)
        {
            HitPoints -= damage;
        }

        public void PairWithMinion(BossEnemy minion)
        {

            mMinion= minion; 

        }
        public override string ToString()
        {
            string result = string.Format("Name: {0}, hit points: {1}, ", Name, HitPoints);

            return result;
        }


    }
    
}
