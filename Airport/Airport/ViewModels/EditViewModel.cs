using Airport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.ViewModels
{
    public class EditViewModel
    {
        public Schedule_In schedule_In { get; set; }
        public Schedule_Out schedule_Out { get; set; }
    }
}
