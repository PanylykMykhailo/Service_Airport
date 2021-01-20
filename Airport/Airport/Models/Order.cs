using Airport.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public Schedule_Out CityStart { get; set; }
        public Schedule_In CityFinish{ get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public int Quantity { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


    }

}
