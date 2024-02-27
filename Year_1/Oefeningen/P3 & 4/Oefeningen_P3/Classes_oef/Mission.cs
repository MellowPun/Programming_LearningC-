using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Classes_oef
{
    internal class Mission
    {
        protected string mMissionName;
        protected string mIntroText;
        protected string mState;
        protected int mPointsWhenCompleted;
        protected string mOutroText;

        public Mission(string missionName)
        {
            mMissionName = missionName;
        }
        // moet encapsuleren mag dus geen console in omdat bepaalde dingen dit miss niet kunnen lezen 
        public string MissionName
        {
            get 
            {
                return mMissionName; 
            }
            /*set 
            {
                mMissionName = value; 
            }*/

        }
         public string IntroText
        {
            get 
            {
                return mIntroText; 
            }

            set 
            {
                mIntroText = value; 
            }
        }

        public string OutroText
        {
            get 
            { 
                return mOutroText; 
            }
            set 
            {
                mOutroText = value; 
            }
        }

        public string State
        {
            get
            { 
                return mState; 
            }
            set
            {
                mState = value;
            }
        }

        public int PointsWhenCompleted
        {
            get
            {
                return mPointsWhenCompleted;
            }
            set
            {
                mPointsWhenCompleted = value;
            }
        }


        public string Complete(out int score)
        {
            //add to score 
            score = 600;
            score += PointsWhenCompleted;
            //Set state to completed
            State = "Completed";

            //return outro text
            return OutroText;

        }

        public string StartMission()
        {
            //set state to start
            State= "In Progress";
            
            //return introtext
            return IntroText;

        }
        public void FailMission()
        {
            State = "Failed";
            OutroText = "Inset Coin to continue...";

        }

        public override string ToString()
        {
            string result = string.Empty;
            string description= string.Empty;
            
            description = OutroText;

            if(State == "In Progress")
            {
                description= IntroText;
            }
            
            result = string.Format("Mission \"{0}\" is in state: {1}, description: {2}  ",
                MissionName,
                State,
                description);

            return result;
        }



    }
}
