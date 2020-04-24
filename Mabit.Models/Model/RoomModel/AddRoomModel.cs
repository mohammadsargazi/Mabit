using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.RoomModel
{
    public class AddRoomModel
    {
        public int[] picturesId { get; set; }
        public string title { get; set; }
        public int cityId { get; set; }
        public string address { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public int structureId { get; set; }
        public int[] textureOptionsId { get; set; }
        public int[] locationOptionsId { get; set; }
        public int roomTypeId { get; set; }
        public int singleBedCount { get; set; }
        public int doubleBedCount { get; set; }
        public int extraBedCount { get; set; }
        public int buildingArea { get; set; }
        public int landArea { get; set; }
        public int roomCount { get; set; }
        public int standardCapacity { get; set; }
        public int maxCapacity { get; set; }
        public int[] locationTypeId { get; set; }
        public List<int> optionsId { get; set; }
        public string checkingTime { get; set; }
        public string checkoutTime { get; set; }
        public int minimumDays { get; set; }
        public int[] customRulesId { get; set; }
        public int middleWeekPrice { get; set; }
        public int holydayPrice { get; set; }
        public int peakDayPrice { get; set; }
        public int extraPersonPrice { get; set; }
        public int longDaysDiscountPercent1 { get; set; }
        public int longDaysDiscountPercent2 { get; set; }
        public string textureDescription { get; set; } 
        public string optionsDescription { get; set; }
        public string rulesDescription { get; set; }
        public string description { get; set; }
        public string aboutRoom { get; set; }
    }
}
public class AddRoomResultModel
{
    public bool submited { get; set; }
}