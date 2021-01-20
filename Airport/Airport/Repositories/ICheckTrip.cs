using Airport.Models;
using Airport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Repositories
{
    public interface ICheckTrip
    {
        public TicketViewModel CheckTrip(SearchTrip searchTrip);
        
    }
}
