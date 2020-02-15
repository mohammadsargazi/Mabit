using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class DiscountCode:BaseModel
    {
        public string Code { get; set; }
        public int Percent { get; set; }
        public double Price { get; set; }
        public double Max { get; set; }
        public string ExpireDate { get; set; }
        public bool Enabled { get; set; }
        public User SpecialUser { get; set; }
        public int SpecialUserId { get; set; }
        public UserBookedRoom UserBookedRoom { get; set; }
        public int UserBookedRoomId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
