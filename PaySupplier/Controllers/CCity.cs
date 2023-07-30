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
    public class CCity
    {       
        public static List<City> getCitys()
        {
            List<City> list = new List<City>(); 
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM cities";

                    list = connection.Query<City>(sql).ToList();
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
