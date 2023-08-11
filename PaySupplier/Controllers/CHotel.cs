using MySql.Data.MySqlClient;
using PaySupplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.Common;
using MySqlX.XDevAPI;

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
                        "descriptionAgency,idCity, categoryHotel) " +
                        "VALUES (@nameHotel, @phoneNumber, @mobileNumber, @email, @address, @statusHotel, @descriptionAgency, @idCity, @categoryHotel)";
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
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    var sql = "INSERT INTO hotels (nameHotel, phoneNumber, mobileNumber, email, address, statusHotel," +
                              "descriptionHotel, idCity, categoryHotel) " +
                              "VALUES (@nameHotel, @phoneNumber, @mobileNumber, @email, @address, @statusHotel, " +
                              "@descriptionHotel, @idCity,@categoryHotel);" +
                              "SELECT LAST_INSERT_ID();"; // Obtiene el último ID generado

                    // Use ExecuteScalar para obtener el ID generado
                    int newHotelId = connection.ExecuteScalar<int>(sql, currentHotel);

                    return Convert.ToInt32(newHotelId);
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return -1; // O cualquier otro valor que indique que ocurrió un error
            }
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
        public static bool updateAllHotelAndServices(Hotel hotel, List<HotelService> hotelService)
        {
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //-- Inicio Transaq SQL
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            //-- Se actualiza la informacion del hotel -- Hotel
                            bool updateHotelAux = CHotel.updateHotel(hotel);
                            //--se procede a actualizar
                           
                            if (updateHotelAux == true)
                            {
                                //-- Insertar o actualizar informacion de Hotel Service
                                foreach (var service in hotelService)
                                {
                                    if (service.idHotelServices == 0) //-- Es un nuevo registro
                                    {
                                        bool servicioInsertado = CHotelServices.createHotelService(service);
                                        // Si no se pudo insertar el servicio, deshacer la transacción y salir
                                        if (!servicioInsertado)
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        bool servicioActualizado = CHotelServices.updateHotelService(service);
                                        // Si no se pudo actualizar el servicio, deshacer la transacción y salir
                                        if (!servicioActualizado)
                                        {
                                            transaction.Rollback();
                                            return false;
                                        }
                                    }
                                   
                                }
                                // Si todo se ha realizado correctamente, confirmar la transacción
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
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

                throw;
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
                        " email = @email, address = @address," +
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
        public static Hotel getHotel(string idHotel)
        {
            Hotel hotel = new Hotel();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    var query = "SELECT * FROM hotels WHERE statusHotel = 1 AND idHotels = @HotelId;";
                    hotel = connection.QueryFirstOrDefault<Hotel>(query, new { HotelId = idHotel });
                    return hotel;
                }
            }
            catch (Exception)
            {
                // Manejo de errores

                return hotel;
            }
        }
        public static List<Hotel> getHotelAllData()
        {
            List<Hotel> HotelList = new List<Hotel>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    // Paso 1: Obtener los detalles básicos de los hoteles
                    HotelList = connection.Query<Hotel>("SELECT h.*, c.name as nameCity FROM hotels h JOIN cities c on h.idCity = c.idCity WHERE statusHotel = 1 ORDER BY idHotels DESC LIMIT 20;").ToList();
                    
                    return HotelList;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return HotelList;
            }
        }
        public static List<Hotel> getHotelLike(string searchText)
        {
            List<Hotel> HotelList = new List<Hotel>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    searchText = "%" + searchText + "%";
                    HotelList = connection.Query<Hotel>("SELECT h.*, c.name AS nameCity FROM hotels h JOIN cities c ON h.idCity = c.idCity WHERE statusHotel = 1 AND h.nameHotel LIKE @SearchText", new { SearchText = searchText }).ToList();
                    return HotelList;
                }
            }
            catch (Exception)
            {
                // Manejo de errores
                return HotelList;
            }
        }
        public static List<HotelWithAllData> getHotelAllData2()
        {
            List<HotelWithAllData> hotels = new List<HotelWithAllData>();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    //   
                    /*var sql = "SELECT idService, nameService FROM services";
                    var services = connection.Query<Service>(sql).ToList();
                    var dynamicColumns = new List<string>();
                    // Iteramos sobre los servicios para construir las partes de la consulta dinámica.
                    foreach (var service in services)
                    {
                        var idService = service.idService;
                        dynamicColumns.Add($@"MAX(CASE WHEN S.idService = {idService} THEN {idService} END) AS idService{idService},
                             MAX(CASE WHEN S.idService = {idService} THEN S.nameService END) AS service{idService},
                             MAX(CASE WHEN S.idService = {idService} THEN HS.priceConfidencial END) AS priceConfidencial_servicio{idService},
                             MAX(CASE WHEN S.idService = {idService} THEN HS.pricePublic END) AS pricePublic_servicio{idService},
                             MAX(CASE WHEN S.idService = {idService} THEN HS.priceBooking END) AS priceBooking_servicio{idService}");
                    }
                    string dynamicColumnsSql = string.Join(",", dynamicColumns);
                    // Concatenamos las partes de la consulta dinámica.
                    string fullQuery = $@"SELECT H.idCity, C.name AS nombreCity, H.idHotels, H.namehotel, H.categoryHotel, H.mobileNumber as cellPhone, H.phoneNumber as phone, H.email, {dynamicColumnsSql}
                             FROM hotels H
                             INNER JOIN cities C ON H.idCity = C.idCity
                             LEFT JOIN hotelservices HS ON H.idHotels = HS.idHotels
                             LEFT JOIN services S ON HS.idService = S.idService
                             GROUP BY H.idCity, C.name, H.idHotels, H.namehotel, H.categoryHotel, H.mobileNumber, H.phoneNumber, H.email;";*/

                    //hotels = connection.Query<HotelWithAllData>(fullQuery).ToList();
                    var services = connection.Query<Service>("SELECT idService, nameService FROM services").ToList();

                    // Creamos una lista para almacenar las partes de la consulta dinámica.
                    var dynamicColumns = new List<string>();

                    // Iteramos sobre los servicios para construir las partes de la consulta dinámica.
                    foreach (var service in services)
                    {
                        var idService = service.idService;
                        dynamicColumns.Add($@"MAX(CASE WHEN S.idService = {idService} THEN {idService} END) AS idService{idService},
                                     MAX(CASE WHEN S.idService = {idService} THEN S.nameService END) AS service{idService},
                                     MAX(CASE WHEN S.idService = {idService} THEN HS.priceConfidencial END) AS priceConfidencial_servicio{idService},
                                     MAX(CASE WHEN S.idService = {idService} THEN HS.pricePublic END) AS pricePublic_servicio{idService},
                                     MAX(CASE WHEN S.idService = {idService} THEN HS.priceBooking END) AS priceBooking_servicio{idService}");
                    }

                    // Concatenamos las partes de la consulta dinámica.
                    string dynamicColumnsSql = string.Join(",", dynamicColumns);

                    // Segunda parte: construimos la consulta completa y la ejecutamos usando Dapper.
                    string fullQuery = $@"SELECT H.idCity, C.name AS nombreCity, H.idHotels, H.namehotel, H.categoryHotel, H.mobileNumber as cellPhone, H.phoneNumber as phone, H.email, {dynamicColumnsSql}
                                 FROM hotels H
                                 INNER JOIN cities C ON H.idCity = C.idCity
                                 LEFT JOIN hotelservices HS ON H.idHotels = HS.idHotels
                                 LEFT JOIN services S ON HS.idService = S.idService
                                 GROUP BY H.idCity, C.name, H.idHotels, H.namehotel, H.categoryHotel, H.mobileNumber, H.phoneNumber, H.email;";


                    // Ejecutamos la consulta completa.
                    var hotels2 = connection.Query<HotelWithAllData>(fullQuery).ToList();
                    return hotels2;
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
