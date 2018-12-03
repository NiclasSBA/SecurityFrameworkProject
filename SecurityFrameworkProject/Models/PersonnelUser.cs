using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class PersonnelUser
    {
        [Key]
        public int Id { get; set; }

        public int PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}