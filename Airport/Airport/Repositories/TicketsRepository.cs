using Airport.Data;
using Airport.Models;
using Airport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Repositories
{
    public class TicketsRepository : ITicketsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TicketsRepository()
        {
        }

        public TicketsRepository(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }
        public TicketViewModel CityStart()
        {
            var selectcity1 = _dbContext.City.ToList();
            int[] Quantity = new int[] { 1, 2, 3, 4, 5, 6 };

            return new TicketViewModel { City = selectcity1, Quantity = Quantity };

        }
        

        public TicketViewModel CityFinish()
        {
            
                var selectcity2 = _dbContext.City.ToList();
                return new TicketViewModel
                {
                    City = selectcity2

                };
            
        }
    
    }
}
