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
        public static int  createHotelId(Hotel currentHotel)
        {
            string connectionString = connection.GetConnectionString();
            //try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "INSERT INTO hotels (nameHotel, phoneNumber, mobileNumber, email, address, statusHotel," +
                              "descriptionHotel, idCity) " +
                              "VALUES (@nameHotel, @phoneNumber, @mobileNumber, @email, @address, @statusHotel, " +
                              "@descriptionHotel, @idCity);" +
                              "SELECT LAST_INSERT_ID();"; // Obtiene el último ID generado

                    // Use ExecuteScalar para obtener el ID generado
                    int newHotelId = connection.ExecuteScalar<int>(sql, currentHotel);

                    return Convert.ToInt32(newHotelId);
                }
            }
            /*catch (Exception)
            {
                // Manejo de errores

                return -1; // O cualquier otro valor que indique que ocurrió un error
            }*/
        }
        public static bool createHotelWithServices(Hotel currentHotel, List<HotelService> hotelServices)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Iniciar la transacción
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Primero, insertar el hotel y obtener el ID generado
                            int hotelId = createHotelId(currentHotel);

                            // Si el ID generado es válido (mayor que cero), continuar con la inserción de los servicios del hotel
                            if (hotelId > 0)
                            {
                                // Asignar el ID del hotel a cada servicio
                                foreach (var service in hotelServices)
                                {
                                    service.idHotels = hotelId;
                                }

                                // Insertar los servicios del hotel
                                foreach (var service in hotelServices)
                                {
                                    bool servicioInsertado = CHotelServices.createHotelService(service);

                                    // Si no se pudo insertar el servicio, deshacer la transacción y salir
                                    if (!servicioInsertado)
                                    {
                                        transaction.Rollback();
                                        return false;
                                    }
                                }

                                // Si todo se ha realizado correctamente, confirmar la transacción
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                // Si no se pudo obtener el ID del hotel, deshacer la transacción y salir
                                transaction.Rollback();
                                return false;
                            }
                        }
                        catch (Exception)
                        {
                            // Si ocurre una excepción durante la transacción, deshacerla
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de errores generales
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
