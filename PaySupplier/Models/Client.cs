using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string nameClient { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public DateTime dateCreated { get; set; }
        public int status { get; set; }
        public string documentType { get; set; }
        public string documentNumber { get; set; }
        public int idCountry { get; set; }
    }
}
