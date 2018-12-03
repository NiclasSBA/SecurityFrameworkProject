using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class SecurityPractice
    {
        [Key]
        public int SecurityPracticeId { get; set; }
        public string Name { get; set; }


        //What Gdpr articles the securitypractice relates to
        public virtual ICollection<GdprArticle> RelatedGpdrArticles { get; set; }


       

        //What Businesfunction secuirty practice relates to
        public int BusinessFunctionId { get; set; }
        public virtual BusinessFunction  BusinessFunction { get; set; }


        //which maturitylevels that relates to securitypractice
        public virtual ICollection<MaturityLevel> MaturityLevels { get; set; }
    }
}