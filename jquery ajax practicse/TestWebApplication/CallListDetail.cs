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
    
    public partial class CallListDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CallListDetail()
        {
            this.CallListDetailsAdditionals = new HashSet<CallListDetailsAdditional>();
            this.CallListDetailsAdditionals1 = new HashSet<CallListDetailsAdditional>();
            this.CallListDetailsAdditionals2 = new HashSet<CallListDetailsAdditional>();
        }
    
        public long ID { get; set; }
        public Nullable<int> CallListID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Details { get; set; }
        public Nullable<System.DateTime> ScheduledTime { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Attempts { get; set; }
        public Nullable<System.DateTime> DOC { get; set; }
        public Nullable<System.DateTime> DOM { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> FlagID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> AssignedBy { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
        public Nullable<int> CallBackUserId { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<bool> IsSoftDial { get; set; }
        public Nullable<int> TenantId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallListDetailsAdditional> CallListDetailsAdditionals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallListDetailsAdditional> CallListDetailsAdditionals1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallListDetailsAdditional> CallListDetailsAdditionals2 { get; set; }
    }
}