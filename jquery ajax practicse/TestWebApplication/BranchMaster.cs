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
    
    public partial class BranchMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BranchMaster()
        {
            this.BranchGatewayMappings = new HashSet<BranchGatewayMapping>();
            this.ExtensionMappings = new HashSet<ExtensionMapping>();
        }
    
        public int id { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public Nullable<int> StateID { get; set; }
        public string ConnectionString { get; set; }
        public string FallBackWebServerUrl { get; set; }
        public string FallBackCommServerUrl { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BranchGatewayMapping> BranchGatewayMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtensionMapping> ExtensionMappings { get; set; }
    }
}
