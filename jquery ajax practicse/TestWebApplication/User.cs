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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.AgentCallTimeStatus = new HashSet<AgentCallTimeStatu>();
            this.AgentCallTimeStatusLogs = new HashSet<AgentCallTimeStatusLog>();
            this.AppRolePermissionMappers = new HashSet<AppRolePermissionMapper>();
        }
    
        public int ID { get; set; }
        public string UserCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> BranchId { get; set; }
        public string Flat_Building { get; set; }
        public string Street_lane { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Landmark { get; set; }
        public string PinCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string Password { get; set; }
        public Nullable<int> PasswordQuestionID { get; set; }
        public string PasswordAnswer { get; set; }
        public Nullable<bool> IsPasswordSystemGenerated { get; set; }
        public Nullable<System.DateTime> LastPasswordChangedDate { get; set; }
        public Nullable<int> FailedPasswordAttemptCount { get; set; }
        public Nullable<bool> IsPasswordReset { get; set; }
        public Nullable<System.DateTime> LastLockoutDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<bool> IsFirstLogin { get; set; }
        public bool IsLocked { get; set; }
        public bool IsActive { get; set; }
        public Nullable<bool> IsloggedIn { get; set; }
        public string Tokken { get; set; }
        public Nullable<int> CallDestination { get; set; }
        public string EscalationMail1 { get; set; }
        public string EscalationMail2 { get; set; }
        public string TerminalID { get; set; }
        public string BranchIds { get; set; }
        public Nullable<int> CallPreference { get; set; }
        public Nullable<int> TenantID { get; set; }
        public Nullable<int> VirtualExtension { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentCallTimeStatu> AgentCallTimeStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgentCallTimeStatusLog> AgentCallTimeStatusLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppRolePermissionMapper> AppRolePermissionMappers { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
    }
}
