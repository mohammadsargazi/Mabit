using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class FileRecord : BaseModel
    {
        public string Content { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }
        public string UniqueId { get; set; }
        public List<User> Users { get; set; }
        public List<RoomPicture> RoomPictures { get; set; }


    }
}
