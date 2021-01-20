using Airport.Models;
using Airport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Repositories
{
    public interface ITicketsRepository
    {
        public TicketViewModel CityStart();
        public TicketViewModel CityFinish();
        


    }
}
