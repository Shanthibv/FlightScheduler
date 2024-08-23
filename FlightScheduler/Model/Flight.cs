using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightScheduler.Model
{
    public class Flight
    {
        public int FlightNumber {  get; set; }
        public string DepartureCity {  get; set; }
        public string ArrivalCity {  get; set; }
        public int Day {  get; set; }
        public int Capacity { get; set; }
        public List<string> Orders { get; set; }
        public Flight(int flightNumber, string departureCity, string arrivalCity, int day, int capacity)
        {
            FlightNumber = flightNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            Day = day;
            Capacity = capacity;
            Orders = new List<string>();
        }
        public bool CanAccommodateOrder()
        {
            return Orders.Count < Capacity;
        }
        public void AddOrder(string orderId)
        {
            if (CanAccommodateOrder())
            {
                Orders.Add(orderId);
            }
        }
    }
}
