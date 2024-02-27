using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_oef
{   //EXAMENVRAAG MOTHAFUCKA
    internal class Enemy
    {
        // ctrl + R zorgt voor naamverandering
        // F2 aanpassen van naam
        // private int mHitpoints; is hetzelfde als int mHitPoints; private betekent dat er een beschermlaag is.
        protected int mHitPoints;
        protected string mName;
        protected Enemy mMinion;
        
        //"get"  you get a value . Dus als je een value van de waarde wilt lezen  gebruikt je get
        //"set" you set a value. Dus als je een value in de waarde wilt plaatsen gebruik je de set
        public int HitPoints
        {
            get { return mHitPoints; }
            set { mHitPoints = CheckForPositiveValue(value); }


        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        protected int CheckForPositiveValue(int inputInt)
        {
            if(inputInt>= 0)
            {
                return inputInt;
            }
            else
            {
                return 0;
            }
        }
        public Enemy Minion
        {
            get
            {
                return mMinion;
            }
        }

        

        //if(input<0){ return=0}
        // return intputInt;
        public void TakeDamage(int damage)
        {
            HitPoints-=damage;
        }
        // als ge mHitpoints gebruikt gebruik je de protected int 
        // als ge Hitpoints gebruikt gebruikt ge de getter en setter

        public void PairWithMinion(Enemy minion)
        {
            mMinion = minion;
        }
        public override string ToString()
        {
            string result = string.Format("Name:{0}, hitpoints: {1}", Name, HitPoints);
            
            return result;
        }
    }
}
