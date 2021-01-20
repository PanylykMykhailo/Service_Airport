using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.ViewModels
{
    public class ScheduleViewModel
    {
        public IEnumerable<Schedule_In> schedule_In { get; set; }
        public IEnumerable<Schedule_Out> schedule_Out { get; set; }
        
        
        

    }
}
