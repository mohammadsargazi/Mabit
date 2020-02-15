using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Room:BaseModel
    {
        public int CityId { get; set; }
        public string Village { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int LocationTypeId { get; set; }
        public string AboutRoom { get; set; }
        public int StructureId { get; set; }
        public int RoomCount { get; set; }
        public float BuildingArea { get; set; }
        public float LandArea { get; set; }
        public int StandardCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public int SingleBedCount { get; set; }
        public int DoubleBedCount { get; set; }
        public int ExtraBedCount { get; set; }
        public bool NeedVerify { get; set; }
        public string TextureDescription { get; set; }
        public string OptionsDescription { get; set; }
        public string CheckingTime { get; set; }
        public string CheckoutTime { get; set; }
        public int MinimumDays { get; set; }
        public string RulesDescription { get; set; }
        public int CurrencyUnitTypeId { get; set; }
        public double MiddleWeekPrice { get; set; }
        public double HolydayPrice { get; set; }
        public double PeakDayPrice { get; set; }
        public double ExtraPersonPrice { get; set; }
        public int LongDaysDiscountPercent1 { get; set; }
        public int LongDaysDiscountPercent2 { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool Verfied { get; set; }
        public string VerificationDate { get; set; }
        public int OwnerUserId { get; set; }
        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public RoomType RoomType { get; set; }
        public User OwnerUser { get; set; }
        public CurrencyUnitType CurrencyUnitType { get; set; }
        public Structure Structure { get; set; }
        public City City { get; set; }
        public LocationType LocationType { get; set; }
        public List<RoomPicture> Pictures { get; set; }
        public List<LocationOption> LocationOptions { get; set; }
        public List<TextureOption> TextureOptions { get; set; }
        public List<Option> Options { get; set; }
        public List<CustomRule> CustomRules { get; set; }
        public List<AvailableDay> AvailableDays { get; set; }
        public List<RoomBookmark> RoomBookmarks { get; set; }
        public List<RoomLike> Likes { get; set; }
        public List<UserMarketedRoom> UserMarketedRooms { get; set; }
        public List<UserBookedRoom> UserBookedRooms { get; set; }
        public List<RoomComment> RoomComments { get; set; }


    }
}
