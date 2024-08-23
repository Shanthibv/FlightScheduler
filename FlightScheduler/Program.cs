using FlightScheduler.Interface;
using FlightScheduler;
public class Program
{
    public static void Main(string[] args)
    {
        IFlightScheduleLoader flightScheduleLoader = new FlightScheduleLoader();
        IOrderLoader orderLoader = new JsonOrderLoader();

        FlightSchedule flightSchedule = new FlightSchedule(flightScheduleLoader, orderLoader);

        // Provide the path to the JSON file
        string ordersFilePath = "C:\\Users\\srmma\\source\\repos\\FlightScheduler\\FlightScheduler\\orders.json";
        flightSchedule.ScheduleFlights(ordersFilePath);
    }
 }