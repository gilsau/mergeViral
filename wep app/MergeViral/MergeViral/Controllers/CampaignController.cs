using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MergeViral.Models;
using MergeViral.Data.Repos;

namespace MergeViral.Controllers
{
    public class CampaignController : Controller
    {
        [HttpGet]
        public ActionResult List(int Id=0)
        {
            //delete a campaign, then return a list
            if (Id > 0) {

            }

            return View(CampaignRepo.GetAll(1000));
        }
                
        [HttpPost]
        public JsonResult Create(CampaignMdl mdl)
        {
            return Json(new object());
        }
                
        [HttpGet]
        public ActionResult RewardSetup()
        {
            //get list of rewards
            List<RewardMdl> lst = new List<RewardMdl>();
            
            return View(lst);
        }

        [HttpPost]
        public ActionResult RewardSetup(RewardMdl mdl)
        {
            return View();
        }

        [HttpGet]
        public ActionResult LandPg()
        {
            //get list of share pages
            LandPgMdl pg = new LandPgMdl();

            return View(pg);
        }

        [HttpPost]
        public ActionResult LandPg(LandPgMdl mdl)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SharePg()
        {
            //get list of share pages
            SharePgMdl pg = new SharePgMdl();

            return View(pg);
        }

        [HttpPost]
        public ActionResult SharePg(SharePgMdl mdl)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Social()
        {
            //get list of social posts
            List<SocialPostMdl> lst = new List<SocialPostMdl>();

            return View(lst);
        }

        [HttpPost]
        public ActionResult Social(List<SocialPostMdl> lst)
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmailSetup()
        {
            EmailSetupMdl emStp = new EmailSetupMdl();

            return View(emStp);
        }

        [HttpPost]
        public ActionResult EmailSetup(EmailSetupMdl mdl)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Launch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Launch(LaunchSetupMdl mdl)
        {
            return View();
        }
    }
}