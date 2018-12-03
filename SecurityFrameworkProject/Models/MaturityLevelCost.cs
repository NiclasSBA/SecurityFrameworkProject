using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class MaturityLevelCost
    {

        public int Id { get; set; }
        public string Description { get; set; }

        public int MaturityLevelId { get; set; }
        public virtual MaturityLevel MaturityLevel { get; set; }
    }
}