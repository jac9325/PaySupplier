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
    public class CHotel
    {
        public static bool createHotel(Hotel currentHotel)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "INSERT INTO hotels (nameHotel, phoneNumber, mobileNumber, email, address, statusHotel," +
                        "descriptionAgency,idCity) " +
                        "VALUES (@nameHotel, @phoneNumber, @mobileNumber, @email, @address, @statusHotel, @descriptionAgency, @idCity)";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentHotel);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return false;
            }
        }
        public static bool updateHotel(Hotel currentHotel)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "UPDATE hotels SET nameHotel = @nameHotel," +
                        " phoneNumber = @phoneNumber, mobileNumber = @mobileNumber," +
                        " email = @email, address = @address, statusHotel= @statusHotel," +
                        "idCity = @idCity, descriptionHotel = @descriptionHotel " +
                        "WHERE idHotels = @idHotels;";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentHotel);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return false;
            }
        }
        public static List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT * FROM hotels WHERE statusHotel = 1";

                    hotels = connection.Query<Hotel>(sql).ToList();
                    return hotels;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return hotels;
            }
        }
    }
}
