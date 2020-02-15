using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class ArticleCategoryGroup:BaseModel
    {
        public List<ArticleCategory> ArticleCategories { get; set; }
    }
}
