using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class AccountsPayables
    {
        public int idCount { get; set; }
        public int idBooking { get; set; }
        public decimal amountPaid { get; set; }
        public decimal remainingAmount { get; set; }
        public string statusPaid { get; set; }
        public int status { get; set; }
        public string remarks { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
