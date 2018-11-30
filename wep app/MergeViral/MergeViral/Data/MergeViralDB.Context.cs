﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MergeViralDBEntities : DbContext
    {
        public MergeViralDBEntities()
            : base("name=MergeViralDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignLocation> CampaignLocations { get; set; }
        public virtual DbSet<CampaignType> CampaignTypes { get; set; }
        public virtual DbSet<EmailNotification> EmailNotifications { get; set; }
        public virtual DbSet<LandingPage> LandingPages { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }
        public virtual DbSet<RewardType> RewardTypes { get; set; }
        public virtual DbSet<SocialPost> SocialPosts { get; set; }
        public virtual DbSet<SocialPostType> SocialPostTypes { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<View> Views { get; set; }
    }
}
