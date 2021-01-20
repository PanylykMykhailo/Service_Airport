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
    public class Booking : IBooking
    {
        private readonly ApplicationDbContext _dbContext;

        public Booking()
        {
        }

        public Booking(ApplicationDbContext dbContex)
        {

            _dbContext = dbContex;
        }
        public TicketViewModel Bookings(string schudeloutID, SearchTrip searchTrip)
        {

            if (schudeloutID != null && schudeloutID == searchTrip.SearchTripID.ToString())
            {

                var schedule_Out = _dbContext.Orders.Include(a => a.CityStart).Where(a => a.CityStart.ToString() == searchTrip.CityStart.ToString());
                return new TicketViewModel
                {
                    order = (Order)schedule_Out
                };
            }

            else
            {
                return null;
            }


        }
    }
}
