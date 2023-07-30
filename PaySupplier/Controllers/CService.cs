using Dapper;
using MySql.Data.MySqlClient;
using PaySupplier.Models;
using PaySupplier.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Controllers
{
    public class CService
    {
        public static bool createService(Service currentService)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "INSERT INTO services (nameService, description, statusService, idTypeService) " +
                        "VALUES (@nameService, @description, @statusService, @idTypeService)";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentService);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return false;
            }
        }

        public static List<Service> getServices()
        {
            List<Service> services = new List<Service>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM services WHERE statusService = 1";

                    services = connection.Query<Service>(sql).ToList();
                    return services;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return services;
            }
        }
        public static List<Service> getServicesLike(string searchText)
        {
            List<Service> services = new List<Service>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM services WHERE statusService = 1 AND nameService LIKE @searchText";

                    services = connection.Query<Service>(sql, new { searchText = "%" + searchText + "%" }).ToList();
                    return services;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return services;
            }
        }

    }
}
