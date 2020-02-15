using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class City:BaseModel
    {
        public List<Room> Rooms { get; set; }
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
    }
}
