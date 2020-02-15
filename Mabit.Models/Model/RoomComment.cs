using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomComment:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }

    }
}
