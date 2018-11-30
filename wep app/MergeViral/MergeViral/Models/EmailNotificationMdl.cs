using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class EmailNotificationMdl
    {
        public int Id { get; set; }
        public CampaignMdl Campaign { get; set; }
        public bool? SendAfterRegistration { get; set; }
        public bool? SendWhenSignsUp { get; set; }
        public bool? SendWhenRewardUnlocked { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ServerHost { get; set; }
        public int? ServerPort { get; set; }
        public string Password { get; set; }
        public string EncryptionType { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}