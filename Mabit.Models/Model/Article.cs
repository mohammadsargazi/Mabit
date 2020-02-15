using System;
using System.Collections.Generic;
using System.Text;

namespace Mabit.Models.Model
{
    public class Article:BaseModel
    {
        public List<ArticleArticleCategory> ArticleArticleCategories { get; set; }
        public string SummaryEn { get; set; }
        public string SummaryFa { get; set; }
        public string SummaryAr { get; set; }
        public string ContentEn { get; set; }
        public string ContentFa { get; set; }
        public string ContentAr { get; set; }
        public bool Enabled { get; set; }
    }
}
