using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Comment:BaseModel
    {
        public string TextEn { get; set; }
        public string TextFa { get; set; }
        public string TextAr { get; set; }
        public User User { get; set; }
        public List<RoomComment> RoomComments { get; set; }
        public List<ArticleComment> ArticleComments { get; set; }


    }
}
