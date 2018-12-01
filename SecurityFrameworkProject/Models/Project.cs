using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        //PUT PROJECTMANAGER HERE



    }
}