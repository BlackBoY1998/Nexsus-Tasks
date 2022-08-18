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
    
    public partial class Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permission()
        {
            this.AppRolePermissionMappers = new HashSet<AppRolePermissionMapper>();
            this.Roles = new HashSet<Role>();
            this.SubRolePermissionMappers = new HashSet<SubRolePermissionMapper>();
        }
    
        public int PermissionID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string PermissionName { get; set; }
        public string PermissionCode { get; set; }
        public bool AllowDelete { get; set; }
        public Nullable<int> OrgID { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppRolePermissionMapper> AppRolePermissionMappers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubRolePermissionMapper> SubRolePermissionMappers { get; set; }
    }
}
