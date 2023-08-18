using MySql.Data.MySqlClient;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PaySupplier.Controllers
{
    public  class CCurrency
    {
        public static List<Currency> getCurrency()
        {
            List<Currency> list = new List<Currency>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM currencys";

                    list = connection.Query<Currency>(sql).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return list;
            }
        }
    }
}
