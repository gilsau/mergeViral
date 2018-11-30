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
    
    public partial class Template
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Template()
        {
            this.LandingPages = new HashSet<LandingPage>();
        }
    
        public int Id { get; set; }
        public string BackgroundImg { get; set; }
        public string BackgroundColor { get; set; }
        public string TitleText { get; set; }
        public string TitleFontFamily { get; set; }
        public Nullable<int> TitleFontSize { get; set; }
        public string TitleBackgroundColor { get; set; }
        public string BtnText { get; set; }
        public string BtnFontFamily { get; set; }
        public Nullable<int> BtnFontSize { get; set; }
        public string BtnBackgroundColor { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandingPage> LandingPages { get; set; }
    }
}
