using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevelQuestion
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Value_00 { get; set; }
        public string Value_02 { get; set; }
        public string Value_05 { get; set; }
        public string Value_10 { get; set; }


      


        public int MaturityLevelId { get; set; }
        public virtual MaturityLevel MaturityLevel { get; set; }
    }
}