using Mabit.Models.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class HomeViewModel
    {
        public List<TopCity> TopCities { get; set; }
        public List<TopRoom> TopRooms { get; set; }
    }
    public class PlaceItemsTop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double Rate { get; set; }
        public int UserRate { get; set; }
        public List<Facility> Facilities { get; set; }
        public int Area { get; set; }
        public int RoomCount { get; set; }
        public class Facility
        {
            public bool HasBed { get; set; }
            public bool HasInternet { get; set; }
            public bool HasTelevision { get; set; }
            public bool HasHeater { get; set; }
            public bool DinningSalon { get; set; }


        }

    }

    public class PopularCity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int HomeCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
