using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.HotelModel
{
    public class AddHotelRoomModel
    {
        public int Flour { get; set; }
        public int Room { get; set; }
        public int HotelCategoryId { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public int HotelId { get; set; }
    }
    public class AddHotelRoomResultModel
    {
        public bool submited { get; set; }
    }
}
