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
    
    public partial class AddressBook
    {
        public int Addressid { get; set; }
        public string Addresstitle { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ClientCode { get; set; }
        public string Branch { get; set; }
        public string HomeAddress { get; set; }
        public string BusinessAddress { get; set; }
        public string HomePinCode { get; set; }
        public string Registered { get; set; }
        public string ContactType { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessPinCode { get; set; }
        public Nullable<int> HomeCountryid { get; set; }
        public Nullable<int> HomeStateid { get; set; }
        public Nullable<int> HomeCityid { get; set; }
        public int BusinessCountryid { get; set; }
        public int BusinessStateid { get; set; }
        public int BusinessCityid { get; set; }
    
        public virtual AddressBook AddressBook1 { get; set; }
        public virtual AddressBook AddressBook2 { get; set; }
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        public virtual City City2 { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual State State1 { get; set; }
    }
}