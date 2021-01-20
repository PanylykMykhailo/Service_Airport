using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class SearchTrip
    {
        [Key]
        public int SearchTripID { get; set; }
        public int CityStart { get; set; }
        public int CityFinish { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public int Quantity { get; set; }
    }
}
