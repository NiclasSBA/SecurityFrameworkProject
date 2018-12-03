using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityFrameworkProject.Models
{

    //Scorecard takes 2 foreign keys, the pahse it relates to, and the securitypractice that it holds value for
    public class ScoreCard
    {
        public int ScoreCardId { get; set; }
        public string Title { get; set; }
        public double BeforeValue { get; set; }
        public double AfterValue {get; set;}

        public int ProjectPhaseId { get; set; }
        public virtual ProjectPhase ProjectPhase { get; set; }

        public int SecurityPracticeId { get; set; }
        public virtual SecurityPractice SecurityPractice { get; set; }


    }
}