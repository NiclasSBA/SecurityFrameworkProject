using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class GdprArticleItem
    {

        [Key]
        public int ArticleItemId { get; set; }
        public string Description { get; set; }
        
    }
}