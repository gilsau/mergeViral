using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MergeViral.Models;
using MergeViral.Data.Repos;

namespace MergeViral.Data.Repos
{
    public static class CampaignRepo
    {
        private static MergeViralDBEntities db = new MergeViralDBEntities();

        public static RepoResult<CampaignMdl> Create(CampaignMdl mdl) {
            RepoResult<CampaignMdl> result = new RepoResult<CampaignMdl>();

            try
            {
                db.Campaigns.Add(MapperRepo.MapEntity(mdl));
                db.SaveChanges();
            }
            catch (Exception ex) {
                result.Success = false;
                result.UsrMsg = ex.Message;

                string innerMsg = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                LogRepo.LogErr(string.Format("ErrMsg: {0}\r\nSource: {1}\r\nStackTrace: {2}\r\nInner Msg: {3}", ex.Message, ex.Source, ex.StackTrace, innerMsg));
            }

            return result;
        }

        public static RepoResult<CampaignMdl> GetAll(int acctId)
        {
            RepoResult<CampaignMdl> result = new RepoResult<CampaignMdl>();

            try
            {
                result.ReturnList = db.Campaigns.Where(c => c.AccountId == acctId)
                    .AsEnumerable()
                    .Select(c => MapperRepo.MapEntity(c))
                    .ToList();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.UsrMsg = ex.Message;

                string innerMsg = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                LogRepo.LogErr(string.Format("ErrMsg: {0}\r\nSource: {1}\r\nStackTrace: {2}\r\nInner Msg: {3}", ex.Message, ex.Source, ex.StackTrace, innerMsg));
            }

            return result;
        }
    }
}