using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class Service
    {
        public int idService { get; set; }
        public string nameService { get; set; }
        public string description { get; set; }
        public int statusService { get; set; }
        public int idTypeService { get; set; }
    }
}
