//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MergeViral.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lead
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public string ReferralLink { get; set; }
        public string RefererIP { get; set; }
        public string RefererBrowser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    
        public virtual Campaign Campaign { get; set; }
    }
}
