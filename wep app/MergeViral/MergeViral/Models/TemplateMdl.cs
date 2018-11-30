using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MergeViral.Models
{
    public class TemplateMdl
    {
        public int Id { get; set; }
        public string BackgroundImg { get; set; }
        public string BackgroundColor { get; set; }
        public string TitleText { get; set; }
        public string TitleFontFamily { get; set; }
        public int? TitleFontSize { get; set; }
        public string TitleBackgroundColor { get; set; }
        public string BtnText { get; set; }
        public string BtnFontFamily { get; set; }
        public int? BtnFontSize { get; set; }
        public string BtnBackgroundColor { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}