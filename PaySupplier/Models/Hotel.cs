using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Hotel
    {
        public int idHotel { get; set; }
        public string nameHotel { get; set; }
        public string phoneNumber { get; set; }
        public string mobileNumber { get;set; }
        public string email { get; set; }
        public string address { get; set; }
        public int statusHotel { get; set; }
        public string descriptionHotel { get; set; }
        public int idCity { get; set; }
    }
}
