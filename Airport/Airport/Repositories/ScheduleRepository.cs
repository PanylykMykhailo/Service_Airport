using Airport.Data;
using Airport.ViewModels;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Airport.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ScheduleRepository()
        {
        }

        public ScheduleRepository(ApplicationDbContext dbContex) 
        {
            _dbContext = dbContex;
        }
        public ScheduleViewModel Flightin()
        {
            var schedule_Out = _dbContext.Schedule_2.Include(a => a.CityStart).Include(a=>a.CityFinish).ToList().OrderBy(s => s.TimeOutAirport);
            List<Schedule_In> schedule_In = null;
            return new ScheduleViewModel
            {
                schedule_In = schedule_In,
                schedule_Out = schedule_Out

            };
        }

        public ScheduleViewModel Flightout()
        {

            var schedule_In = _dbContext.Schedule_1.Include(a => a.CityStart).Include(a => a.CityFinish).ToList().OrderBy(s => s.TimeinAirport);
            List<Schedule_Out> schedule_Out = null;
            return new ScheduleViewModel
            {
                schedule_In = schedule_In,
                schedule_Out = schedule_Out

            };
        }

       
      
    }
}
