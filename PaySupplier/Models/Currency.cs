using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public  class Currency
    {
        public int idCurrency { get; set; }
        public string nameCurrency { get; set; }
        public int main { get; set; }
        public string codCurrency { get; set; }
        public DateTime dateCreated { get; set; }
        public int status { get; set; }
    }
}
