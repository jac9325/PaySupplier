using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Booking
    {
        public int idBooking { get; set; }
        public int idClient { get; set;}
        public int idService { get; set; }
        public int idUser { get; set;}
        public DateTime dateBooking { get; set; }
        public decimal amount { get; set; }
        public string observations { get; set; }
        public DateTime dateCreated { get; set; }
        public string statusBooking { get; set; }
        public int status { get; set; }
        public decimal prepayment { get; set; }
    }
}
