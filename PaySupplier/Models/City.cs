using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class City
    {
        public int idCity { get; set; }
        public int idCountry { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
