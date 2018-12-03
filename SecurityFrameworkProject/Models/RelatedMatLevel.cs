using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class RelatedMatLevel
    {

        [Key]
        public int Id { get; set; }


        public int MaturityLevelId { get; set; }
        public int RelatedMaturityLevelId { get; set; }
       
    }
}