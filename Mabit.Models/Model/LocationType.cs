using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class LocationType:BaseModel
    {
        public List<Room> Rooms { get; set; }
    }
}
