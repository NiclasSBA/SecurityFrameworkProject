using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevelPersonnel
    {
        [Key]
        public int Id {get; set;}
        public string Description { get; set; }

        public int MaturityLevelId { get; set; }
        public virtual MaturityLevel MaturityLevel { get; set; }
        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }



    }
}