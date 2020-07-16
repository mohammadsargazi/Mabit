using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.HotelModel
{
    public class AddHotelModel
    {
        public int? PictureId { get; set; }
        public List<int> PicturesId { get; set; }
        public string Title { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public List<int> TextureOptionsId { get; set; }
        public int HotelTypeId { get; set; }
        public byte Star { get; set; }
        public int? RoomNum { get; set; }
        public int? FloorNum { get; set; }
        public string InternalSpecificationDesc { get; set; }
        public List<int> LocationTypeId { get; set; }
        public List<int> OptionsId { get; set; }
        public string CheckingTime { get; set; }
        public string CheckoutTime { get; set; }
        public int? MinimumDays { get; set; }
        public List<int> CustomRulesId { get; set; }
        public string TextureDescription { get; set; }
        public string OptionsDescription { get; set; }

        public string Description { get; set; }
        public List<int> HotelRoomsId { get; set; }

        public string textureDescription { get; set; }
        public string optionsDescription { get; set; }
        public string rulesDescription { get; set; }
        public string description { get; set; }
        public string aboutHotel { get; set; }
    }
    public class AddHotelResultModel
    {
        public bool submited { get; set; }
    }
}
