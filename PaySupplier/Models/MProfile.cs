using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class MProfile
    {
        public int idProfile { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int status { get; set; }
        public DateTime dateCreated { get; set; }
    }
}
