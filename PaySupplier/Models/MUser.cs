using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class MUser
    {
        public int idUser {  get; set; }
        public string name { get; set; }    
        public string surname { get; set; }
        public string email { get; set; }
        public DateTime dateCreated { get; set; }
        public int status { get; set; }
        public int idProfile { get; set; }
        public string user { get; set; }
        public string password { get; set; }   

    }
}
