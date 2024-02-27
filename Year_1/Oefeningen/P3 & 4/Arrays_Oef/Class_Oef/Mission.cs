using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    public enum States
    {
        ToDo,
        InProgress,
        Failed,
        Completed
    }

    internal class Mission
    {
        protected States MissionState;
        protected string mMissionName;
        protected string mIntroText;
        protected string mState;
        protected byte mPointsWhenCompleted;
        protected string mOutroText;

        public Mission(string missionName)
        {
            mMissionName = missionName;
        }

        //dit is een contructor hier heb je geen setter nodig voor MissionName

        public string MissionName
        {
            get { return mMissionName; }

            //set { mMissionName = value; }
        }
        public string IntroText
        {
            get { return mIntroText; }
            set { mIntroText = value; }
        }

        public string Outrotext
        {
            get { return mOutroText; }
            set { mOutroText = value; }
        }
        public string State
        {
            get { return mState; }

            set { mState = value; }
        }

        public byte PointsWhenCompleted
        {
            get { return mPointsWhenCompleted;}
            set { mPointsWhenCompleted = value; }
        }
        
        public string StartMission()
        {
            State = "In Progress";

            return IntroText;
        }

        public string Complete(out int scorePoints)
        {
            int score = 0;
            score += PointsWhenCompleted;
            State = "Complete";

            scorePoints = score;


            return Outrotext;


        }
        
        
        public void Fail()
        {
            State = "Failed";
            Outrotext = "Inser Coin to continue...";
        }

        public override string ToString()
        {
            
            string description = Outrotext;
            if(State =="In Progress")
            {
                description = IntroText;
            }
            string result = string.Format("Mission \"{0}\" is in state: {1}, description: {2}"
                , MissionName
                , State
                , description);

            return result;

        }

    }
}
