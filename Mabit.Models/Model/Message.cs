using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Message:BaseModel
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public User FromUser { get; set; }
        public int FromUserId { get; set; }
        public User ToUser { get; set; }
        public int ToUserId{ get; set; }

    }
}
