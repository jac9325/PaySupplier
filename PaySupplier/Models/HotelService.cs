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
        //public int idService { get; set;}
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdate { get; set; }
        /*public decimal priceConfidencial { get; set; }
        public decimal pricePublic { get; set; }
        public decimal priceBooking { get; set; }*/

    }
    public class HotelServiceWithName
    {
        public int idService { get; set; }
        public string nameService { get; set; }
        public decimal priceConfidencial { get; set; }
        public decimal pricePublic { get; set; }
        public decimal priceBooking { get; set; }
    }

    public class HotelServiceAllData
    {
        public int idHotelServices { get; set; }
        public int idHotels { get; set; }
        public string nameHotels { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public int idService { get; set; }
        public string nameService { get; set; }
        public decimal priceConfidencial { get; set; }
        public decimal priceBooking { get; set; }
        public decimal pricePublicada { get; set; }
        public string nameCity { get; set; }
    }
}
