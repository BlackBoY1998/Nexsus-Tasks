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
    
    public partial class UserActivity
    {
        public int ActivityID { get; set; }
        public Nullable<int> UserSessionID { get; set; }
        public string ActivityDone { get; set; }
        public Nullable<System.DateTime> ActivityTime { get; set; }
        public string ActivityPage { get; set; }
        public string AttemptUserID { get; set; }
        public string MachineIP { get; set; }
        public string MachineName { get; set; }
        public string MachineUserName { get; set; }
        public Nullable<int> TenantId { get; set; }
    }
}
