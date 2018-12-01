using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class BusinessFunction
    {
        public int BusinessFunctionId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<SecurityPractice> SecurityPractices { get; set; }
    }
}