using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class Personnel
    {

        [Key]
        public int PersonnelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RelationToCompany { get; set; }

    }
}