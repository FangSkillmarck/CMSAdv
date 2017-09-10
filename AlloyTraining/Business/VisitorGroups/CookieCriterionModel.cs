using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Personalization.VisitorGroups;

namespace AlloyTraining.Business.VisitorGroups
{
    public class CookieCriterionModel: CriterionModelBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }

    }
}