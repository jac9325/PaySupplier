using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public static class connection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString;
        }
    }
}
