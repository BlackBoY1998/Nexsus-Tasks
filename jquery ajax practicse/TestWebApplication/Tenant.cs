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
    
    public partial class Tenant
    {
        public long TenantID { get; set; }
        public string TenantName { get; set; }
        public string TenantAddress { get; set; }
        public string TenantCity { get; set; }
        public string TenantCountry { get; set; }
        public string TenantPinCode { get; set; }
        public string TenantContact { get; set; }
        public string TenantMobile { get; set; }
        public string Email { get; set; }
        public string WebURL { get; set; }
        public System.DateTime CreationTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleterUserId { get; set; }
        public System.DateTime DeletionTime { get; set; }
        public System.DateTime LastModificationTime { get; set; }
        public int LastModifierUserId { get; set; }
        public int CreatorUserId { get; set; }
        public string Plan_ID { get; set; }
        public string PlanExpiryDate { get; set; }
        public string Lic_Days { get; set; }
        public string Remark { get; set; }
    }
}
