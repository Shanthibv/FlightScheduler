using FlightScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightScheduler.Interface
{
    public interface IOrderLoader
    {
        List<Order> LoadOrders(string filePath);
    }
}
