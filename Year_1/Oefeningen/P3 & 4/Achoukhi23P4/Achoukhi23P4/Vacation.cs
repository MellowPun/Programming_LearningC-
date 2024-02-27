using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achoukhi23P4
{
    public enum VacationType
    {
        Beach,
        CityTrip,
        Hiking
    }

    internal class Vacation
    {
        protected List<Flight> mFlights;
        protected Stay mStay;
        protected VacationType mVacationType;

        public Vacation(Stay stay, VacationType vacationType)
        {
            mStay = stay;
            mVacationType = vacationType;
            mFlights = new List<Flight>();
        }

        public List<Flight> Flights
        {
            get { return mFlights; }
        }
        public Stay Stay
        {
            get { return mStay; }
        }

        public VacationType VacationType 
        { 
            get { return mVacationType; } 
        }

        public void AddFlight(Flight flight)
        {
            mFlights.Add(flight);

        }
        //Nog niet opgelost
        protected double GetTotalPrice()
        {
            double totalPrice = 0;
            for(int i = 0; i < mFlights.Count; i ++)
            {
                totalPrice += mFlights[i].Price;
            }
            totalPrice += mStay.Price;

            

            return totalPrice;
        }
        protected double GetTotalFlightTime(out int numberOfFlights)
        {
            double totalHours = 0;
            numberOfFlights = mFlights.Count;
            for(int i = 0;i<mFlights.Count; i++)
            {
                totalHours += mFlights[i].Hours;
            }
            return totalHours;
        }

        public override string ToString()
        {
            string result = string.Format("Je vertrekt naar hotel \"{0}\" in {1} voor een {2} vakantie. " +
                "De total tijd van je vluchten zal {3} uur zijn({4} vluchten). Je zal {5} dagen in het hotel verblijven. " +
                "De totale trip zal {6}€ kosten. Daarna keer je terug naar {7}.", mStay.Hotel, mFlights[0].Destination, mVacationType,
                GetTotalFlightTime(out int numberOfFlights), numberOfFlights, mStay.Days, GetTotalPrice(), mFlights[1].Destination);


            return result;
        }


    }
}
