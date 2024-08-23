using FlightScheduler.Interface;
using FlightScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightScheduler
{
    public class FlightScheduleLoader:IFlightScheduleLoader
    {
        public List<Flight> LoadSchedule()
        {
            return new List<Flight>()
            {
                new Flight(1,"YUL","YYZ",1,20),
                new Flight(2,"YUL","YYC",1,20),
                new Flight(3,"YUL","YVR",1,20),
                new Flight(4,"YUL","YYZ",2,20),
                new Flight(5,"YUL","YYC",2,20),
                new Flight(6,"YUL","YVR",2,20),
            };
        }
    }
}
