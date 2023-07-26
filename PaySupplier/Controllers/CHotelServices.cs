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
    public class CHotelServices
    {
        public static bool createHotel(HotelService currentHotelService)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "INSERT INTO hotelServices (idHotels, idService, dateCreated, dateUpdate, sConfidencial, sBooking,sPublicada," +
                        "mConfidencial, mBooking, mPublicada, tConfidencial, tBooking, tPublicada) " +
                        "VALUES (@idHotels, @idService, @dateCreated, @dateUpdate, @sConfidencial, @sBooking, @sPublicada," +
                        "@mConfidencial, @mBooking, @mPublicada, @tConfidencial, @tBooking, @tPublicada)";
                    // Use the Query method to execute the query and return a list of objects    
                    int rowsAffected = connection.Execute(sql, currentHotelService);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return false;
            }
        }
        public static bool updateHotelService(HotelService currentHotelService)
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
                    int rowsAffected = connection.Execute(sql, currentHotelService);
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return false;
            }
        }
        public static List<Hotel> getHotelService()
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
