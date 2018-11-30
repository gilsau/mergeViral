using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class RepoResult<T>
    {
        public bool Success { get; set; }
        public List<T> ReturnList { get; set; }
        public int ReturnId { get; set; }
        public string UsrMsg { get; set; }

        public RepoResult() {
            Success = true;
            ReturnId = 0;
            ReturnList = null;
            UsrMsg = null;
        }
    }
}