using Airport.ViewModels;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Repositories
{
    public interface IScheduleRepository
    {
        public ScheduleViewModel Flightout();
        public ScheduleViewModel  Flightin();
       


    }
}
