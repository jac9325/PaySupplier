using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace PaySupplier.Models
{
    public class Hotel
    {
        public int idHotels { get; set; }
        public string nameHotel { get; set; }
        public string phoneNumber { get; set; }
        public string mobileNumber { get;set; }
        public string email { get; set; }
        public string address { get; set; }
        public int statusHotel { get; set; }
        public string descriptionHotel { get; set; }
        public int idCity { get; set; }
        public string categoryHotel { get; set; }
        public string nameCity { get; set; }
    }
    public class HotelWithAllData
    {
        public int idCity { get; set; }
        public string nameCity { get; set; }
        public int idHotels { get; set; }
        public string categoryHotel { get; set; }
        public string nameHotel { get; set; }
        public string phone { get; set; }
        public string cellPhone { get; set; }      
        public string email { get; set; }
        public int idService { get; set; }
        public string nameService { get; set; }
        public int idHotelServices { get; set; }
        public decimal priceConfidencial { get; set; }
        public decimal priceBooking { get; set; }
        public decimal pricePublic { get; set; }
    }
}
