using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevelGoal
    {
        [Key]
        public int MLevelGoalId { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }


        public int MaturityLevelId { get; set; }
        public virtual MaturityLevel MaturityLevel { get; set; }
    }
}