using Dapper;
using MySql.Data.MySqlClient;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Controllers
{
    public class CTypeService
    {
        public static List<TypeService> getTypeServices()
        {
            List<TypeService> TypeServices = new List<TypeService>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM typeservices";

                    TypeServices = connection.Query<TypeService>(sql).ToList();
                    return TypeServices;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return TypeServices;
            }
        }
    }
}
