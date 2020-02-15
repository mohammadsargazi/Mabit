
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model.Common
{
    public class TopCity:BaseModel
    {
        public string Province { get; set; }
        public int ProvinceId { get; set; }
        public List<Room> Rooms { get; set; }
        public int RoomCount { get; set; }
        public string ImageUrl { get; set; }
        private string _picUrl;
        public string profileImageUrl { get { return _picUrl; } set { _picUrl = "http://185.173.105.237:81" + value; } }
    }
}
