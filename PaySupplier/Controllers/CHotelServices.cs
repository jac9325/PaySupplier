using MySql.Data.MySqlClient;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;

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
                    var sql = "INSERT INTO hotelservices (idHotels, idService, dateCreated, dateUpdate, priceConfidencial, priceBooking, pricePublic,idCurrency)" +
                        "VALUES (@idHotels, @idService, @dateCreated, @dateUpdate, @priceConfidencial, @priceBooking, @pricePublic, @idCurrency)";
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
                        " priceBooking = @priceBooking, idCurrency = @idCurrency WHERE idHotelServices = @idHotelServices;";
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
        public static List<HotelWithServices> getHotelService()
        {
            List<HotelWithServices> hotels = new List<HotelWithServices>();
            string connectionString = connection.GetConnectionString();
            //try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var sql = "SELECT h.idHotels, h.nameHotel,h.phoneNumber AS telefono, h.mobileNumber AS celular, h.categoryHotel, c.name AS nameCity, h.address, h.email,GROUP_CONCAT(s.nameService) AS nameServices, GROUP_CONCAT(hs.priceConfidencial) AS priceConfidencial, GROUP_CONCAT(hs.pricePublic) AS pricePublic, GROUP_CONCAT(hs.priceBooking) AS priceBooking, GROUP_CONCAT(s.idService) AS idServices FROM hotelservices hs JOIN hotels h ON hs.idHotels = h.idHotels JOIN services s ON hs.idService = s.idService JOIN cities c ON h.idCity = c.idCity GROUP BY h.idHotels, h.nameHotel ORDER BY h.idHotels DESC LIMIT 20;";
                   var hotels2 = connection.Query<HotelWithServices>(sql).ToList();
                   if (hotels2.Count>0)
                    {
                        MessageBox.Show("si entro");
                    }
                    return hotels;
                }
            }
            /*catch (Exception)
            {
                // Manejo de errores

                return hotels;
            }*/
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
                    var query = "SELECT hs.*, s.nameService, c.nameCurrency FROM hotelservices hs JOIN services s ON hs.idService = s.idService JOIN currencys c ON hs.idCurrency = c.idCurrency WHERE idHotels = @HotelId;";
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
