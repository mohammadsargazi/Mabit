using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class ArticleCategory:BaseModel
    {
        public ArticleCategoryGroup ArticleCategoryGroup { get; set; }
        public int ArticleCategoryGroupId { get; set; }
        public List<ArticleArticleCategory> ArticleArticleCategories { get; set; }
    }
}
