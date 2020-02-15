using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class ArticleComment:BaseModel
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}
