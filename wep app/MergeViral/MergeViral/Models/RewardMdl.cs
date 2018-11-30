using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class RewardMdl
    {
        public int Id { get; set; }
        public CampaignMdl Campaign { get; set; }
        public RewardTypeMdl RewardType { get; set; }
        public string Name { get; set; }
        public int PointsMinimum { get; set; }
        public int? PointsDirectSignUp { get; set; }
        public int? PointsReferredSignUp { get; set; }
        public int? PointsReferredLead { get; set; }
        public int? PointsFacebook { get; set; }
        public int? PointsTwitter { get; set; }
        public int? PointsGoogle { get; set; }
        public int? PointsLinkedIn { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }

    public enum RewardTypeMdl
    {
        Url = 1,
        Downloadable = 2,
        CouponCode = 3
    }
}