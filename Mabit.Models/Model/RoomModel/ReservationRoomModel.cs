using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.RoomModel
{
    public class ReservationRoomModel
    {
        public string city { get; set; }
        public string checkinDate { get; set; }
        public string checkoutDate { get; set; }
        public int? peopleCount { get; set; }
        public int? fromPrice { get; set; }
        public int? toPrice { get; set; }
        public int? roomTypeId { get; set; }
        public int? take { get; set; }   
        public int? skip { get; set; }
        public int page { get; set; }
        public int? countryId { get; set; }
        public int? provinceId { get; set; }
        public bool isReady { get; set; }
        public bool isPriceRangeChecked { get; set; }
        public int? roomCount { get; set; }
        public int? bedCount { get; set; }
    }
}
