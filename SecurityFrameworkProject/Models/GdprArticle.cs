using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class GdprArticle
    { 
        [Key]
        public int ArticleId { get; set; }
        public int ArticleNumber { get; set; }
        public string Title { get; set; }

        public virtual ICollection<GdprSuitableRecital> GdprSuitableRecitals { get; set; }
        public virtual ICollection<GdprArticleItem> GdprArticleItems { get; set; }
        public virtual ICollection<SecurityPractice> RelatedSecurityPractices { get; set; }
    }
}