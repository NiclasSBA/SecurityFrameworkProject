using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class ProjectManager
    {
        [Key]
        public int ProjectManagerId { get; set; }

        //We dont add a name to this, since its known from personnelusers inheritance from usermodel

        public DateTime AdminSince { get; set; }
        public bool Enabled { get; set; }

        public int PersonnelUserId { get; set; }
        public virtual PersonnelUser PersonnelUser { get; set; }

    }
}