using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Schedule_Out
    {
        [Key]
        public int ScheduleOutID { get; set; }
        public string Name_Board { get; set; }
        public City CityStart { get; set; }
        public City CityFinish { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime TimeOutAirport { get; set; }
        public decimal Price { get; set; }
        public int Max_Passenger { get; set; }
        public int FreePlace { get; set; }
        public string States { get; set; }
       

    }
}
