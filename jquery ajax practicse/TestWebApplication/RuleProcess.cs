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
    
    public partial class RuleProcess
    {
        public int ID { get; set; }
        public Nullable<int> SystemAlertID { get; set; }
        public Nullable<int> RuleActionId { get; set; }
        public Nullable<bool> IsProcessed { get; set; }
        public Nullable<int> ProcessAttempts { get; set; }
        public string ProcessLog { get; set; }
        public Nullable<int> TenantId { get; set; }
    }
}
