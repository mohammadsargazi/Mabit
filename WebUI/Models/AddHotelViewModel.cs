using Mabit.Models.Model.HotelModel;
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
        public int[] TextureOptionsId { get; set; }
        public string DescDescription { get; set; }
        public int? RoomNum { get; set; }
        public int? FloorNum { get; set; }
        public string InternalSpecificationDesc { get; set; }
        public int[] LocationTypes { get; set; }
        public string AreaCultureDesc { get; set; }
        public int[] OptoptionIds { get; set; }
        public string OptionsDescription { get; set; }
        public string rulesInterTime { get; set; }
        public string rulesExitTime { get; set; }
        public int[] customRulesItem { get; set; }
        public int minimumreservation { get; set; }
    }
    public static class HotelExtentionModel
    {
        public static AddHotelModel ToModel(this AddHotelViewModel model)
        {
            if (model == null)
                return null;
            return new AddHotelModel
            {
                PicturesId = model.picturesId?.ToList(),
               /* PictureId = model.picturesId[0]*/
                HotelTypeId = model.HotelTypeId,
                //Star=  model.HoteStarId,
                TextureOptionsId = model.TextureOptionsId?.ToList(),
                TextureDescription = "",
                RoomNum = model.RoomNum,
                FloorNum = model.FloorNum,
                InternalSpecificationDesc = model.InternalSpecificationDesc,
                LocationTypeId = model.LocationTypes?.ToList(),
                OptionsId = model.OptoptionIds?.ToList(),
                OptionsDescription = model.OptionsDescription,
                CheckingTime = model.rulesInterTime,
                CheckoutTime = model.rulesExitTime,
                MinimumDays = model.minimumreservation,
                CustomRulesId = model.customRulesItem?.ToList(),
                rulesDescription = "",
                Address=model.Address,
                CityId=model.CityId,
                Latitude=model.Latitude,
                Longitude=model.Longitude,
                Title=model.HotelName,
                
            };
        }
    }
}
