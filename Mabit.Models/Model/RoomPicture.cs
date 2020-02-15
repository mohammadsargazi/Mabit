using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomPicture : BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public FileRecord FileRecord { get; set; }
        public int FileRecordId { get; set; }


    }
}
