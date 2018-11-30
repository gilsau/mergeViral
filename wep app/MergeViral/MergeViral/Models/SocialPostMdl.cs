using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class SocialPostMdl
    {
        public int Id { get; set; }
        public CampaignMdl Campaign { get; set; }
        public SocialPostTypeMdl SocialPostType { get; set; }
        public string HandleName { get; set; }
        public string StandardTweet { get; set; }
        public string EmailSubject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string ReferralLink { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }

    public enum SocialPostTypeMdl
    {
        Facebook = 1,
        Twitter = 2,
        Google = 3,
        LinkedIn = 4,
        Email = 5
    }
}