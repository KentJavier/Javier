//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_System.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admins
    {
        public int AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string Email { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public System.DateTime AdminRegistrationDate { get; set; }
        public int RoleId { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}