using Mabit.Models.Model.RoomModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Models
{
    public class AddRoomViewModel
    {
        public List<IFormFile> Files { get; set; }
        public string UnitName { get; set; }
        public int CountryId { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public string address { get; set; }
        public int DescStructuresId { get; set; }
        public List<int> DescTextureOptionsId { get; set; }
        public string DescDescription { get; set; }
        public int MeasurmentRoomTypeId { get; set; }
        public int MeasurmentLocationOptionId { get; set; }
        public int MeasurmentBedRoomNumber { get; set; }
        public int MeasurmentInpBuildingArea { get; set; }
        public int MeasurmentYardArea { get; set; }
        public string DescMeasurment { get; set; }
        public int StandardCapacity { get; set; }
        public int CapacitySingleBed { get; set; }
        public int CapacityMaximumCapacity { get; set; }
        public int CapacityDoubleBed { get; set; }
        public List<int> CapacityLocationTypes { get; set; }
        public string CapacityDescCapacity { get; set; }
        public List<int> OptoptionIds { get; set; }
        public string OptDescOptions { get; set; }
        public string RulesInterTime { get; set; }
        public string RulesExitTime { get; set; }
        public List<int> CustomRulesItem { get; set; }
        public string RuleDesc { get; set; }
        public int MiddleOfTheWeek { get; set; }
        public int Holidays { get; set; }
        public int Weekend { get; set; }
        public int ExtraPeople { get; set; }
        public int LongBookingDiscount1Day { get; set; }
        public int LongBookingDiscount1Percent { get; set; }
        public int LongBookingDiscount2Day { get; set; }
        public int LongBookingDiscount2Percent { get; set; }

    }

}

public static class ExtentionModel
{
    public static AddRoomModel ToModel(this AddRoomViewModel model)
    {
        if (model == null)
            return null;
        return new AddRoomModel
        {
            title = model.UnitName,
            aboutRoom = model.DescDescription,
            textureOptionsId=model.DescTextureOptionsId?.ToArray(),
            structureId=model.DescStructuresId,
            address = model.address,
            buildingArea = model.MeasurmentYardArea,
            checkingTime = model.RulesInterTime,
            checkoutTime = model.RulesExitTime,
            cityId = model.CityId,
            customRulesId = model.CustomRulesItem?.ToArray(),
            description = model.DescDescription,
            doubleBedCount = model.CapacityDoubleBed,
            extraBedCount = model.MeasurmentBedRoomNumber,
            extraPersonPrice = model.ExtraPeople,
            holydayPrice = model.Holidays,
            landArea = model.MeasurmentYardArea,
            roomTypeId=model.MeasurmentRoomTypeId,
            //locationOptionsId=model.MeasurmentLocationOptionId,
            standardCapacity=model.StandardCapacity,
            maxCapacity=model.CapacityMaximumCapacity,
            singleBedCount=model.CapacitySingleBed,
            //locationTypeId=model.CapacityLocationTypes,
            //capicityDesc=model.CapacityDescCapacity,
            optionsId=model.OptoptionIds,
            optionsDescription=model.OptDescOptions,
            rulesDescription=model.RuleDesc,
            middleWeekPrice=model.MiddleOfTheWeek,
            //minimumDays=model.
            //extraPersonPrice=model.ExtraPeople,
            roomCount=model.MeasurmentBedRoomNumber,
            peakDayPrice=model.Weekend,
            longDaysDiscountPercent1=model.LongBookingDiscount1Percent,
            longDaysDiscountPercent2=model.LongBookingDiscount2Percent

        };
    }
}
