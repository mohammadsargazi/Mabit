using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AddHotelViewModel
    {
        public int[] picturesId { get; set; }
        public string HotelName { get; set; }
        public int CityId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Address { get; set; }
        public int HotelTypeId { get; set; }
        public int HoteStarId { get; set; }
        public List<int> TextureOptionsId { get; set; }
        public string DescDescription { get; set; }
        public int? RoomNum { get; set; }
        public int? FloorNum { get; set; }
        public string InternalSpecificationDesc { get; set; }
        public List<int> LocationTypes { get; set; }
        public string AreaCultureDesc { get; set; }
        public List<int> OptoptionIds { get; set; }
        public string OptionsDescription { get; set; }
    }
}
