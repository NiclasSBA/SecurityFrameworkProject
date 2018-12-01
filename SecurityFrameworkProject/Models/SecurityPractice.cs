using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{
    public class SecurityPractice
    {
        public int SecurityPracticeId { get; set; }
        public string Name { get; set; }


        //What Businesfunction secuirty practice relates to
        public int BusinessFunctionId { get; set; }
        public virtual BusinessFunction  BusinessFunction { get; set; }


        //which maturitylevels that relates to securitypractice
        public virtual ICollection<MaturityLevel> MaturityLevels { get; set; }
    }
}