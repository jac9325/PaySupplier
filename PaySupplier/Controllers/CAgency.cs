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
    public class CAgency
    {
        public static bool createAgency(Agency currentAgency)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "INSERT INTO agencys (nameAgency, phoneNumber, mobileNumber, email, address, statusAgency," +
                        "idCity, descriptionAgency) " +
                        "VALUES (@nameAgency, @phoneNumber, @mobileNumber, @email, @address, @statusAgency, @idCity, @descriptionAgency)";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentAgency);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return false;
            }
        }
        public static bool updateAgency(Agency currentAgency)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "UPDATE agencys SET nameAgency = @nameAgency," +
                        " phoneNumber = @phoneNumber, mobileNumber = @mobileNumber," +
                        " email = @email, address = @address, statusAgency = @statusAgency," +
                        "idCity = @idCity, descriptionAgency = @descriptionAgency " +
                        "WHERE idAgency = @idAgency;";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentAgency);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return false;
            }
        }
        public static List<Agency> getAgencys()
        {
            List<Agency> services = new List<Agency>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM agencies WHERE statusAgency = 1";

                    services = connection.Query<Agency>(sql).ToList();
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
