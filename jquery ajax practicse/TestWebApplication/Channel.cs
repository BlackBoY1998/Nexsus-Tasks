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
    
    public partial class Channel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Channel()
        {
            this.CampaignChannels = new HashSet<CampaignChannel>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Alias { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<short> Type { get; set; }
        public Nullable<int> Cli { get; set; }
        public Nullable<int> Priority { get; set; }
        public int Mode { get; set; }
        public Nullable<bool> NonSoftdial { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignChannel> CampaignChannels { get; set; }
    }
}