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
    
    public partial class CampaignUserGroup
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public int UserGroupID { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        public virtual UserGroup UserGroup { get; set; }
    }
}
