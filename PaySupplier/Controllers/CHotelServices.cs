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
        public static bool createHotelService(HotelService currentHotelService)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "INSERT INTO hotelservices (idHotels, idService, dateCreated, dateUpdate, priceConfidencial, priceBooking, pricePublic)" +
                        "VALUES (@idHotels, @idService, @dateCreated, @dateUpdate, @priceConfidencial, @priceBooking, @pricePublic)";
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
                    var sql = "UPDATE hotelservices SET dateUpdate = @dateUpdate," +
                        " priceConfidencial = @priceConfidencial, pricePublic = @pricePublic," +
                        " priceBooking = @priceBooking WHERE idHotelServices = @idHotelServices;";
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
        public static List<HotelService> getHotelServiceByIdHotel(int idHotel)
        {
            List<HotelService> hotelService = new List<HotelService>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var query = "SELECT hs.*, s.nameService FROM hotelservices hs JOIN services s ON hs.idService = s.idService WHERE idHotels = @HotelId;";
                    hotelService = connection.Query<HotelService>(query, new { HotelId = idHotel }).ToList();
                    return hotelService;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return hotelService;
            }
        }
    }
}
