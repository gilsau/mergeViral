using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace MergeViral.Data.Repos
{
    public class LogRepo
    {
        public static void LogErr(string str)
        {
            string timeStamp = DateTime.Now.ToShortDateString().Replace("/", "_");
            string filePath = string.Format("{0}/{1}", HttpContext.Current.Server.MapPath("/logs/"), timeStamp);
            File.AppendAllText(filePath, str);
        }
    }
}