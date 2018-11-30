using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MergeViral.Models;

namespace MergeViral.Data.Repos
{
    public static class MapperRepo
    {
        public static Campaign MapEntity(CampaignMdl mdl) {
            return new Campaign()
            {
                AccountId = mdl.Owner.Id,
                Name = mdl.Name,
                CampaignLocationId = int.Parse(mdl.CampaignLocation.ToString()),
                CampaignTypeId = int.Parse(mdl.CampaignType.ToString()),
                StartDate = mdl.StartDate,
                EndDate = mdl.EndDate,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static CampaignMdl MapEntity(Campaign entity)
        {
            return new CampaignMdl()
            {
                Owner = new UserAcctMdl() {
                    Id = entity.Account.Id,
                    FirstName = entity.Account.FirstName,
                    MiddleName = entity.Account.MiddleName,
                    LastName = entity.Account.LastName,
                    Email = entity.Account.Email
                },
                Name = entity.Name,
                CampaignLocation = entity.CampaignLocation.Id == 1 ? CampaignLocationMdl.MergeViral : CampaignLocationMdl.YourOwnSite,
                CampaignType = entity.CampaignType.Id == 1 ? CampaignTypeMdl.Contest : CampaignTypeMdl.Referral,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Created = entity.Created,
                CreatedBy = entity.CreatedBy,
                LastUpdated = entity.LastUpdated,
                LastUpdatedBy = entity.LastUpdatedBy
            };
        }

        public static EmailNotification MapEntity(EmailNotificationMdl mdl)
        {
            return new EmailNotification()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                SendAfterRegistration = mdl.SendAfterRegistration,
                SendWhenSignsUp = mdl.SendWhenSignsUp,
                SendWhenRewardUnlocked = mdl.SendWhenRewardUnlocked,
                FromName = mdl.FromName,
                FromEmail = mdl.FromEmail,
                ServerHost = mdl.ServerHost,
                ServerPort = mdl.ServerPort,
                Password = mdl.Password,
                EncryptionType = mdl.EncryptionType,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static EmailNotificationMdl MapEntity(EmailNotification entity)
        {
            return new EmailNotificationMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                SendAfterRegistration = entity.SendAfterRegistration,
                SendWhenSignsUp = entity.SendWhenSignsUp,
                SendWhenRewardUnlocked = entity.SendWhenRewardUnlocked,
                FromName = entity.FromName,
                FromEmail = entity.FromEmail,
                ServerHost = entity.ServerHost,
                ServerPort = entity.ServerPort,
                Password = entity.Password,
                EncryptionType = entity.EncryptionType,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static SocialPost MapEntity(SocialPostMdl mdl)
        {
            return new SocialPost()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                SocialPostTypeId = int.Parse(mdl.SocialPostType.ToString()),
                HandleName = mdl.HandleName,
                StandardTweet = mdl.StandardTweet,
                EmailSubject = mdl.EmailSubject,
                Title = mdl.Title,
                Description = mdl.Description,
                Img = mdl.Img,
                ReferralLink = mdl.ReferralLink,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static SocialPostMdl MapEntity(SocialPost entity)
        {
            return new SocialPostMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                SocialPostType = entity.SocialPostTypeId == 1 ? SocialPostTypeMdl.Facebook : entity.SocialPostTypeId == 2 ? SocialPostTypeMdl.Twitter : entity.SocialPostTypeId == 3 ? SocialPostTypeMdl.Google : entity.SocialPostTypeId == 4 ? SocialPostTypeMdl.LinkedIn : SocialPostTypeMdl.Email,
                HandleName = entity.HandleName,
                StandardTweet = entity.StandardTweet,
                EmailSubject = entity.EmailSubject,
                Title = entity.Title,
                Description = entity.Description,
                Img = entity.Img,
                ReferralLink = entity.ReferralLink,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static LandingPage MapEntity(LandingPageMdl mdl)
        {
            return new LandingPage()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                TemplateId = mdl.Template.Id,
                ReferralLink = mdl.ReferralLink,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static LandingPageMdl MapEntity(LandingPage entity)
        {
            return new LandingPageMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                Template = MapperRepo.MapEntity(entity.Template),
                ReferralLink = entity.ReferralLink,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static Template MapEntity(TemplateMdl mdl)
        {
            return new Template()
            {
                Id = mdl.Id,
                BackgroundImg = mdl.BackgroundImg,
                BackgroundColor = mdl.BackgroundColor,
                TitleText = mdl.TitleText,
                TitleFontFamily = mdl.TitleFontFamily,
                TitleFontSize = mdl.TitleFontSize,
                TitleBackgroundColor = mdl.TitleBackgroundColor,
                BtnText = mdl.BtnText,
                BtnFontFamily = mdl.BtnFontFamily,
                BtnFontSize = mdl.BtnFontSize,
                BtnBackgroundColor = mdl.BtnBackgroundColor,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static TemplateMdl MapEntity(Template entity)
        {
            return new TemplateMdl()
            {
                Id = entity.Id,
                BackgroundImg = entity.BackgroundImg,
                BackgroundColor = entity.BackgroundColor,
                TitleText = entity.TitleText,
                TitleFontFamily = entity.TitleFontFamily,
                TitleFontSize = entity.TitleFontSize,
                TitleBackgroundColor = entity.TitleBackgroundColor,
                BtnText = entity.BtnText,
                BtnFontFamily = entity.BtnFontFamily,
                BtnFontSize = entity.BtnFontSize,
                BtnBackgroundColor = entity.BtnBackgroundColor,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static Reward MapEntity(RewardMdl mdl)
        {
            return new Reward()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                RewardTypeId = int.Parse(mdl.RewardType.ToString()),
                Name = mdl.Name,
                PointsMinimum = mdl.PointsMinimum,
                PointsDirectSignUp = mdl.PointsDirectSignUp,
                PointsReferredSignUp = mdl.PointsReferredSignUp,
                PointsReferredLead = mdl.PointsReferredLead,
                PointsFacebook = mdl.PointsFacebook,
                PointsTwitter = mdl.PointsTwitter,
                PointsGoogle = mdl.PointsGoogle,
                PointsLinkedIn = mdl.PointsLinkedIn,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static RewardMdl MapEntity(Reward entity)
        {
            return new RewardMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                RewardType = entity.RewardTypeId == 1 ? RewardTypeMdl.Url : entity.RewardTypeId == 2 ? RewardTypeMdl.Downloadable : RewardTypeMdl.CouponCode,
                Name = entity.Name,
                PointsMinimum = entity.PointsMinimum,
                PointsDirectSignUp = entity.PointsDirectSignUp,
                PointsReferredSignUp = entity.PointsReferredSignUp,
                PointsReferredLead = entity.PointsReferredLead,
                PointsFacebook = entity.PointsFacebook,
                PointsTwitter = entity.PointsTwitter,
                PointsGoogle = entity.PointsGoogle,
                PointsLinkedIn = entity.PointsLinkedIn,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static Data.View MapEntity(ViewMdl mdl)
        {
            return new Data.View()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                ReferralLink = mdl.ReferralLink,
                RefererIP = mdl.RefererIP,
                RefererBrowser = mdl.RefererBrowser,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static ViewMdl MapEntity(Data.View entity)
        {
            return new ViewMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                ReferralLink = entity.ReferralLink,
                RefererIP = entity.RefererIP,
                RefererBrowser = entity.RefererBrowser,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static Lead MapEntity(LeadMdl mdl)
        {
            return new Lead()
            {
                Id = mdl.Id,
                CampaignId = mdl.Campaign.Id,
                ReferralLink = mdl.ReferralLink,
                RefererIP = mdl.RefererIP,
                RefererBrowser = mdl.RefererBrowser,
                Name = mdl.Name,
                Email = mdl.Email,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static LeadMdl MapEntity(Lead entity)
        {
            return new LeadMdl()
            {
                Id = entity.Id,
                Campaign = MapperRepo.MapEntity(entity.Campaign),
                ReferralLink = entity.ReferralLink,
                RefererIP = entity.RefererIP,
                RefererBrowser = entity.RefererBrowser,
                Name = entity.Name,
                Email = entity.Email,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static Account MapEntity(UserAcctMdl mdl)
        {
            return new Account()
            {
                Id = mdl.Id,
                FirstName = mdl.FirstName,
                MiddleName = mdl.MiddleName,
                LastName = mdl.LastName,
                Email = mdl.Email,
                Password = mdl.Password,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }

        public static UserAcctMdl MapEntity(Account entity)
        {
            return new UserAcctMdl()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Email = entity.Email,
                Password = entity.Password,
                Deleted = false,
                Created = DateTime.Now,
                CreatedBy = "current user",
                LastUpdated = DateTime.Now,
                LastUpdatedBy = "current user"
            };
        }
    }
}