using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class LocationOption : BaseModel
    {
        public List<RoomLocationOption> RoomLocationOptions { get; set; }
    }
}
