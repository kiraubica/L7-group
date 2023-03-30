using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_group
{

    public interface IDBItem_DataAccessLayer
    {
        void AddFlight(Flight flight);
        Flight GetFlightById(int id);
        void RemoveFlight(Flight flight);
        void UpdateFlight(Flight oldFlight, Flight newFlight);


    }
}
