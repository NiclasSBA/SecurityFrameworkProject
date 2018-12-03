using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class ProjectPhase
    {
        [Key]
        public int ProjectPhaseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Enabled { get; set; }

        public ICollection<ScoreCard> ScoreCards { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }




}