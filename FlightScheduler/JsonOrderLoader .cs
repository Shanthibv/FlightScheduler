using FlightScheduler.Interface;
using FlightScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlightScheduler
{
    public class JsonOrderLoader : IOrderLoader
    {
        public List<Order> LoadOrders(string filePath)
        {
            var jsonData = System.IO.File.ReadAllText(filePath);
            var orderDict = JsonConvert.DeserializeObject<Dictionary<string, Order>>(jsonData);
            return orderDict.Select(o => new Order(o.Key, o.Value.Destination)).ToList();
        }
    }
}
