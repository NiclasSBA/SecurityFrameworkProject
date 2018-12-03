using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class BusinessFunction
    {
        [Key]
        public int BusinessFunctionId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<SecurityPractice> SecurityPractices { get; set; }
    }
}