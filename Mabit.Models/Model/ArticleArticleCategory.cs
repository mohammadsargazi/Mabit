using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class ArticleArticleCategory:BaseModel
    {
        public Article Article { get; set; }
        public int ArticleId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public int ArticleCategoryId { get; set; }
    }
}
