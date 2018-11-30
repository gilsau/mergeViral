using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class CampaignMdl
    {
        public int Id { get; set; }
        public UserAcctMdl Owner { get; set; }
        public string Name { get; set; }
        public CampaignLocationMdl CampaignLocation { get; set; }
        public CampaignTypeMdl CampaignType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }

    public enum CampaignLocationMdl {
        MergeViral = 1,
        YourOwnSite = 2
    }

    public enum CampaignTypeMdl
    {
        Referral = 1,
        Contest = 2
    }
}