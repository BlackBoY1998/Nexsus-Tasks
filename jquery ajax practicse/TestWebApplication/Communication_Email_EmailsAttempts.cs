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
    
    public partial class Communication_Email_EmailsAttempts
    {
        public int ID { get; set; }
        public Nullable<int> SMTPServerID { get; set; }
        public int EmailsID { get; set; }
        public Nullable<System.DateTime> AttemptedOn { get; set; }
        public Nullable<bool> IsSuccessful { get; set; }
        public string Remarks { get; set; }
    
        public virtual Communication_Email_Emails Communication_Email_Emails { get; set; }
        public virtual Communication_Email_SMTPServer Communication_Email_SMTPServer { get; set; }
    }
}
