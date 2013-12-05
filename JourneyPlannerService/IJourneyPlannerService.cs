using System.Collections.Generic;
using System.ServiceModel;
using Domain;


namespace JourneyPlannerService
{
    [ServiceContract]
    public interface IJourneyPlannerService
    {
        [OperationContract]
        IEnumerable<Journey> GetJourneysByStation(string depart, string arrival);
    }
}
