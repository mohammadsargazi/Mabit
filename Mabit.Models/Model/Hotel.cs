using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Hotel:BaseModel
    {
        public int Star { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
