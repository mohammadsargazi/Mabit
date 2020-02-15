using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class RoomTextureOption:BaseModel
    {
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public TextureOption TextureOption { get; set; }
        public int TextureOptionId { get; set; }

    }
}
