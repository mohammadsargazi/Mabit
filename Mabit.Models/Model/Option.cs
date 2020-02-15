using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Option : BaseModel
    {
        public List<RoomOption> RoomOptions { get; set; }
    }
}
