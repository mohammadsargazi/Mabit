using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.RoomModel
{
    public class SearchRoomModel
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string RTime { get; set; }
        public int LocationTypeId { get; set; }
        public double MiddleWeekPrice { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
