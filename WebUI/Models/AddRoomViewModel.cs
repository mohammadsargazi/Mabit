using LazZiya.ExpressLocalization.Messages;
using Mabit.Models.Model.RoomModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Models
{
    public class AddRoomViewModel
    {
        public int[] picturesId { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        [StringLength(100, ErrorMessage = DataAnnotationsErrorMessages.StringLengthAttribute_ValidationErrorIncludingMinimum, MinimumLength = 6)]
        public string UnitName { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public double longitude { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public double latitude { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int CountryId { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int ProvinceId { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int CityId { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string address { get; set; }
       // [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int DescStructuresId { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public List<int> DescTextureOptionsId { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string DescDescription { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MeasurmentRoomTypeId { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MeasurmentLocationOptionId { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MeasurmentBedRoomNumber { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MeasurmentInpBuildingArea { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MeasurmentYardArea { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string DescMeasurment { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int StandardCapacity { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int CapacitySingleBed { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int CapacityMaximumCapacity { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int CapacityDoubleBed { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public List<int> CapacityLocationTypes { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string CapacityDescCapacity { get; set; }
        //[Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public List<int> OptoptionIds { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string OptDescOptions { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string RulesInterTime { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string RulesExitTime { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public List<int> CustomRulesItem { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public string RuleDesc { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int MiddleOfTheWeek { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int Holidays { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int Weekend { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int ExtraPeople { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int LongBookingDiscount1Day { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int LongBookingDiscount1Percent { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
        public int LongBookingDiscount2Day { get; set; }
        [Required(ErrorMessage = DataAnnotationsErrorMessages.RequiredAttribute_ValidationError)]
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
            textureOptionsId = model.DescTextureOptionsId?.ToArray(),
            structureId = model.DescStructuresId,
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
            roomTypeId = model.MeasurmentRoomTypeId,
            //locationOptionsId=model.MeasurmentLocationOptionId,
            standardCapacity = model.StandardCapacity,
            maxCapacity = model.CapacityMaximumCapacity,
            singleBedCount = model.CapacitySingleBed,
            locationTypeId = model.CapacityLocationTypes?.ToArray(),
            //capicityDesc=model.CapacityDescCapacity,
            optionsId = model.OptoptionIds,
            optionsDescription = model.OptDescOptions,
            rulesDescription = model.RuleDesc,
            middleWeekPrice = model.MiddleOfTheWeek,
            //minimumDays=model.
            //extraPersonPrice=model.ExtraPeople,
            roomCount = model.MeasurmentBedRoomNumber,
            peakDayPrice = model.Weekend,
            longDaysDiscountPercent1 = model.LongBookingDiscount1Percent,
            longDaysDiscountPercent2 = model.LongBookingDiscount2Percent,
            latitude = model.latitude,
            longitude = model.longitude,
            picturesId = model.picturesId
        };
    }
}
