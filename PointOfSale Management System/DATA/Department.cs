//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Clerks = new HashSet<Clerk>();
        }
    
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    
        public virtual ICollection<Clerk> Clerks { get; set; }
    }
}
