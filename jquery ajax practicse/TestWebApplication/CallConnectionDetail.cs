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
    
    public partial class CallConnectionDetail
    {
        public int Id { get; set; }
        public Nullable<long> CallDetailsId { get; set; }
        public Nullable<long> CallAttemptId { get; set; }
        public string AgentTelephone { get; set; }
        public string CustomerTelephone { get; set; }
        public string AgentStatus { get; set; }
        public string CustomerStatus { get; set; }
        public Nullable<System.DateTime> CallDateTime { get; set; }
        public Nullable<System.DateTime> DOM { get; set; }
    }
}