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
    
    public partial class AgentCallTimeStatusLog
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public Nullable<System.TimeSpan> IdleTimeExceed { get; set; }
        public Nullable<System.TimeSpan> BreakTimeExceed { get; set; }
        public Nullable<System.TimeSpan> TotalLoginTimeExceed { get; set; }
        public Nullable<System.TimeSpan> TotalTalkTimeExceed { get; set; }
        public string EscalationMail { get; set; }
        public string Remark { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.TimeSpan> ManualDialModeExceed { get; set; }
        public Nullable<System.TimeSpan> ExtensionRingingExceed { get; set; }
        public Nullable<System.TimeSpan> OutgoingCallDurationExceed { get; set; }
        public Nullable<System.TimeSpan> IncommingCallDurationExceed { get; set; }
    
        public virtual User User { get; set; }
    }
}