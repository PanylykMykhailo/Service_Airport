using Airport.Models;
using Airport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.ViewModels
{
    public class TicketViewModel
    {
        public IEnumerable<City> City { get; set; }
        public City CurrentCity { get; set; }
        public IEnumerable<Schedule_Out> schedule { get; set; }
        public SearchTrip searchTrip { get; set; }
        public Booking booking { get; set; }
        public Order order { get; set; }
        
        public int[] Quantity;
        
    }
}
