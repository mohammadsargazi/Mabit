using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class User:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Birthdate { get; set; }
        public string Salt { get; set; }
        public string HashedPassword { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public int UserTypeId { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public List<RoomBookmark> RoomBookmarks { get; set; }
         public List<RoomLike> RoomLikes { get; set; }
        public List<Comment> Comments { get; set; }
        public FileRecord FileRecord { get; set; }
        public int FileRecordId { get; set; }
        public List<UserMarketedRoom> UserMarketedRooms { get; set; }
        public List<UserBookedRoom> UserBookedRooms { get; set; }
        public List<Room> Rooms { get; set; }
        public List<DiscountCode> DiscountCodes { get; set; }
        public List<UserFinancialRecord> UserFinancialRecords { get; set; }
        public List<Message> Messages { get; set; }

    }
}
