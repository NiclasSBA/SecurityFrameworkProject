using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{

    //You could rename this model to "activity" but I feel like thats to generic. this way, i know that its activities related to the specific mat level
    public class MaturityLevelActivity
    {

        [Key]
        public int ActivitiesMaturityLevelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int MaturityLevelId { get; set; }
        public virtual MaturityLevel MaturityLevel { get; set; }
    }

}
