using System;
using System.Collections.Generic;

namespace Domain
{
    public static class JourneyData
    {
        public static IEnumerable<Journey> GetJourneys()
        {
            return new List<Journey>
                       {
                           new Journey
                               {
                                   DepartureStation = "Ely",
                                   ArrivalStation = "Cambridge",
                                   DepartureTime = new DateTime(2013, 1, 12, 10, 5, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 10, 25, 0),
                                   Platform = 1
                               },
                            new Journey
                               {
                                   DepartureStation = "Cambridge",
                                   ArrivalStation = "Ely",
                                   DepartureTime = new DateTime(2013, 1, 12, 10, 30, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 10, 55, 0),
                                   Platform = 1
                               },
                            new Journey
                               {
                                   DepartureStation = "Ely",
                                   ArrivalStation = "Cambridge",
                                   DepartureTime = new DateTime(2013, 1, 12, 11, 5, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 11, 30, 0),
                                   Platform = 1
                               },
                            new Journey
                               {
                                   DepartureStation = "Cambridge",
                                   ArrivalStation = "Ely",
                                   DepartureTime = new DateTime(2013, 1, 12, 11, 35, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 12, 0, 0),
                                   Platform = 1
                               },
                            new Journey
                               {
                                   DepartureStation = "Ely",
                                   ArrivalStation = "Cambridge",
                                   DepartureTime = new DateTime(2013, 1, 12, 12, 30, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 13, 0, 0),
                                   Platform = 1
                               },
                            new Journey
                               {
                                   DepartureStation = "Cambridge",
                                   ArrivalStation = "Ely",
                                   DepartureTime = new DateTime(2013, 1, 12, 13, 10, 0),
                                   ArrivalTime = new DateTime(2013, 1, 12, 13, 35, 0),
                                   Platform = 1
                               },
                       };
        }
    }
}
