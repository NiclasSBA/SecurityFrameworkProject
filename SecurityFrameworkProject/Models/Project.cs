using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        //PUT PROJECTMANAGER HERE
        public int ProjectManagerId { get; set; }
        public virtual ProjectManager ProjectManager { get; set; }

        public virtual ICollection<ProjectPhase> ProjectPhases { get; set; }

    }
}