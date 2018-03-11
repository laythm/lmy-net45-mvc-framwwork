//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMYFrameWorkMVC.Common.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Setting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Setting()
        {
            this.SettingsFiles = new HashSet<SettingsFile>();
        }
    
        public string Id { get; set; }
        public string Key { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Value { get; set; }
        public int Type { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SettingsFile> SettingsFiles { get; set; }
        public virtual SettingsType SettingsType { get; set; }
    }
}
