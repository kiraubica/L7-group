using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_group
{
    public class DBItem_DataAccessLayer : IDBItem_DataAccessLayer
    {
        private List<Flight> flights = new List<Flight>();

        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public Flight GetFlightById(int id)
        {
            return flights.Find(flight => flight.Id == id);
        }

        public void RemoveFlight(Flight flight)
        {
            flights.Remove(flight);
        }

        public void UpdateFlight(Flight oldFlight, Flight newFlight)
        {
            int index = flights.IndexOf(oldFlight);
            flights[index] = newFlight;
        }
    }
}
