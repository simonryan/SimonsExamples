using System.Collections.Generic;
using System.Linq;
using Domain;

namespace JourneyPlannerService
{
    public class JourneyPlannerService : IJourneyPlannerService
    {
        public IEnumerable<Journey> GetJourneysByStation(string depart, string arrival)
        {
            return
                JourneyData.GetJourneys().Where(
                    j => j.DepartureStation.Equals(depart) && j.ArrivalStation.Equals(arrival)).ToList();
        }
    }
}