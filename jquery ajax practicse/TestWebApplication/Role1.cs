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
    
    public partial class Role1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role1()
        {
            this.RolePermissions = new HashSet<RolePermission>();
        }
    
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Abbrevation { get; set; }
        public Nullable<int> MasterRole { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
