using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevel
    {
      



        [Key]
        public int MaturityLevelId { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }
        public int Level { get; set; }
        public virtual ICollection<RelatedMatLevel> RelatedMaturityLevels { get; set; }
        public virtual ICollection<MaturityLevelActivity> MaturityLevelActivities { get; set; }
        public virtual ICollection<MaturityLevelQuestion> MaturityLevelQuestions { get; set; }
        public virtual ICollection<MaturityLevelGoal> MaturityLevelGoals { get; set; }
        public virtual ICollection<MaturityLevelCost> RelatedMaturityCosts { get; set; }


        public int SecurityPracticeId { get; set; }
        public virtual SecurityPractice SecurityPractice { get; set; }
    }
}