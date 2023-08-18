using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Payment
    {
        public int idPayment { get; set; }
        public int idCount { get; set; }
        public string typePay { get; set; }
        public decimal amountPay { get; set; }
        public string paymentMethod { get; set; }
        public int status { get; set; }
        public string remarks { get; set; }
        public DateTime datePay { get; set; }
    }
}
