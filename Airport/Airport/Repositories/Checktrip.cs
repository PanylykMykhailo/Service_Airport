using Airport.Data;
using Airport.Models;
using Airport.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Repositories
{
    public class Checktrip: ICheckTrip
    {
        private readonly ApplicationDbContext _dbContext;

        public Checktrip()
        {
        }

        public Checktrip(ApplicationDbContext dbContex)
        {
           
            _dbContext = dbContex;
        }
        public TicketViewModel CheckTrip(SearchTrip searchTrip)
        {
            var schedule_Out = _dbContext.Schedule_2.Include(a => a.CityStart).Where(a => a.CityStart.CityID == searchTrip.CityStart).Where(a => a.CityFinish.CityID == searchTrip.CityFinish).Where(a => a.TimeOutAirport.Date == searchTrip.Data.Date).ToList();
          

            return new TicketViewModel { schedule  = schedule_Out };
            }
    }
}
