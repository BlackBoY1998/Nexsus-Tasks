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
    
    public partial class UserGroupDetail
    {
        public int ID { get; set; }
        public int UserGroupID { get; set; }
        public int UserID { get; set; }
        public Nullable<bool> IscampaignSupervisor { get; set; }
        public bool IsSuperVisior { get; set; }
        public Nullable<int> Priority { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        public virtual UserGroup UserGroup { get; set; }
    }
}
