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
    
    public partial class OTPGeneration
    {
        public int ID { get; set; }
        public string FolioNo { get; set; }
        public string MobileNumber { get; set; }
        public string OTP { get; set; }
        public Nullable<System.DateTime> DOC { get; set; }
        public Nullable<int> IsOTPSend { get; set; }
        public Nullable<System.DateTime> Expiry { get; set; }
        public Nullable<System.DateTime> CallDateTime { get; set; }
        public Nullable<bool> MsgDelievered { get; set; }
        public Nullable<int> IsOTPUsed { get; set; }
        public string CallerID { get; set; }
        public string ClientCode { get; set; }
        public Nullable<int> UserID { get; set; }
        public string IncomingCallID { get; set; }
    }
}
