using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySupplier.Models
{
    public class HotelService : HotelServiceWithName
    {
        public int idHotelServices { get; set; }
        public int idHotels { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdate { get; set; }

    }
    public class HotelServiceWithName
    {
        public int idService { get; set; }
        public string nameService { get; set; }
        public decimal priceConfidencial { get; set; }
        public decimal pricePublic { get; set; }
        public decimal priceBooking { get; set; }
        public int idCurrency { get; set; }
        public string nameCurrency { get; set; } 
    }

    public class HotelWithServices
    {
        public int idHotels { get; set; }
        public string nameHotel { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string categoryHotel { get; set; }
        public string nameCity { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string nameServices { get; set; }
        public string idServices { get; set; }
        public string priceConfidencial { get; set; }
        public string priceBooking { get; set; }
        public string pricePublic { get; set; }       
    }
    public class HotelDGV : Hotel
    {
        public int idServices1 { get; set; }
        public string nameService1 { get; set; }       
        public decimal precioConfidencial1 { get; set; }
        public decimal precioBooking1 { get; set; }
        public decimal precioPublic1 { get; set; }
        public int idServices2 { get; set; }
        public string nameService2 { get; set; }
        public decimal precioConfidencial2 { get; set; }
        public decimal precioBooking2 { get; set; }
        public decimal precioPublic2 { get; set; }
        public int idServices3 { get; set; }
        public string nameService3 { get; set; }
        public decimal precioConfidencial3 { get; set; }
        public decimal precioBooking3 { get; set; }
        public decimal precioPublic3 { get; set; }
        public int idServices4 { get; set; }
        public string nameService4 { get; set; }
        public decimal precioConfidencial4 { get; set; }
        public decimal precioBooking4 { get; set; }
        public decimal precioPublic4 { get; set; }
        public int idServices5 { get; set; }
        public string nameService5 { get; set; }
        public decimal precioConfidencial5 { get; set; }
        public decimal precioBooking5 { get; set; }
        public decimal precioPublic5 { get; set; }
        public int idServices6 { get; set; }
        public string nameService6 { get; set; }
        public decimal precioConfidencial6 { get; set; }
        public decimal precioBooking6 { get; set; }
        public decimal precioPublic6 { get; set; }
        public int idServices7 { get; set; }
        public string nameService7 { get; set; }
        public decimal precioConfidencial7 { get; set; }
        public decimal precioBooking7 { get; set; }
        public decimal precioPublic7 { get; set; }
        public int idServices8 { get; set; }
        public string nameService8 { get; set; }
        public decimal precioConfidencial8 { get; set; }
        public decimal precioBooking8 { get; set; }
        public decimal precioPublic8 { get; set; }
        public int idServices9 { get; set; }
        public string nameService9 { get; set; }
        public decimal precioConfidencial9 { get; set; }
        public decimal precioBooking9 { get; set; }
        public decimal precioPublic9 { get; set; }

    }
        public class HotelWithServicesData
        {
            public int idHotels { get; set; }
            public string nameHotel { get; set; }
            public int idCity { get; set; }
            public string nombreCity { get; set; }
            public string services1 { get; set; }
            public decimal priceConfidencial1 { get; set; }
            public decimal pricePublic1 { get; set; }
            public decimal priceBooking1 { get; set; }
            public string services2 { get; set; }
            public decimal priceConfidencial2 { get; set; }
            public decimal pricePublic2 { get; set; }
            public decimal priceBooking2 { get; set; }
            public string services3 { get; set; }
            public decimal priceConfidencial3 { get; set; }
            public decimal pricePublic3 { get; set; }
            public decimal priceBooking3 { get; set; }
            public string services4 { get; set; }
            public decimal priceConfidencial4 { get; set; }
            public decimal pricePublic4 { get; set; }
            public decimal priceBooking4 { get; set; }
        }
}
