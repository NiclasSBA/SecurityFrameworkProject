using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class PhaseUser
    {
        [Key]
        public int Id { get; set; }
        public int TrainingTimeAssigned { get; set; }
        public int TrainingTimeUsed { get; set; }
        public string Description { get; set; }

        public int ProjectPhaseId { get; set; }
        public virtual ProjectPhase ProjectPhase { get; set; }

        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }
    

}

}