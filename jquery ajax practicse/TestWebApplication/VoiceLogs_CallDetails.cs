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
    
    public partial class VoiceLogs_CallDetails
    {
        public long ID { get; set; }
        public string CallID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CallDateTime { get; set; }
        public Nullable<int> CampaignID { get; set; }
        public string Extension { get; set; }
        public string CallerID { get; set; }
        public string CallType { get; set; }
        public string Comments { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> ChannelNo { get; set; }
        public Nullable<int> AttemptID { get; set; }
        public Nullable<double> Duration { get; set; }
        public string CustomData1 { get; set; }
        public string CustomData2 { get; set; }
        public string CustomData3 { get; set; }
        public string BranchCode { get; set; }
        public string FileName { get; set; }
        public bool IsSynchronised { get; set; }
        public Nullable<int> TenantId { get; set; }
    }
}
