//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class CallDisposition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CallDisposition()
        {
            this.CampaignDispositions = new HashSet<CampaignDisposition>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string BackColor { get; set; }
        public Nullable<int> AutoFlag { get; set; }
        public Nullable<int> DispositionType { get; set; }
        public Nullable<bool> CanBeDeleted { get; set; }
        public string TAT { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignDisposition> CampaignDispositions { get; set; }
    }
}
