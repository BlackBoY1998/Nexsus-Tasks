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
    
    public partial class CampaignUser
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public int UserID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> Priority { get; set; }
        public int TenantId { get; set; }
    }
}