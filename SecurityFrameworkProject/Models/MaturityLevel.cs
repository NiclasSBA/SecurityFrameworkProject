using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevel
    {
        public int MaturityLevelId { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }

        public int SecurityPracticeId { get; set; }
        public virtual SecurityPractice SecurityPractice { get; set; }
    }
}