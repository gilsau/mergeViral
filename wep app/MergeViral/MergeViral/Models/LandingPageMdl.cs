using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class LandingPageMdl
    {
        public int Id { get; set; }
        public CampaignMdl Campaign { get; set; }
        public TemplateMdl Template { get; set; }
        public string ReferralLink { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}