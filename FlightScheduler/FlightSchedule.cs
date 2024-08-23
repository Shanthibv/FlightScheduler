using FlightScheduler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightScheduler
{
    public class FlightSchedule
    {
        private readonly IFlightScheduleLoader _flightScheduleLoader;
        private readonly IOrderLoader _orderLoader;
        public FlightSchedule(IFlightScheduleLoader flightScheduleLoader,IOrderLoader orderLoader)
        {
            _flightScheduleLoader = flightScheduleLoader;
            _orderLoader = orderLoader;
        }
        public void ScheduleFlights(string ordersFilePath)
        {
            var flights = _flightScheduleLoader.LoadSchedule();
            var orders = _orderLoader.LoadOrders(ordersFilePath);

            foreach (var order in orders) 
            {
                var flight = flights.FirstOrDefault(f => f.ArrivalCity == order.Destination && f.CanAccommodateOrder());
                if (flight != null)
                {
                    flight.AddOrder(order.OrderId);
                }
                else
                {
                    Console.WriteLine($"Order:{order.OrderId},FlightNumber: not scheduled");
                }
            }

            foreach (var flight in flights)
            {
                foreach(var orderId in flight.Orders)
                {
                    Console.WriteLine($"Order:{orderId},FlightNumber:{flight.FlightNumber} Departure: {flight.DepartureCity}, Arrival: {flight.ArrivalCity}, Day: {flight.Day}");
                }
            }
                
        }
    }
}
