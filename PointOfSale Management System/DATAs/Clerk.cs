//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATAs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clerk
    {
        public Clerk()
        {
            this.SaleOrders = new HashSet<SaleOrder>();
        }
    
        public string ClerkID { get; set; }
        public string ClerkName { get; set; }
        public string Manager { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public int DeptID { get; set; }
        public System.DateTime JoinDate { get; set; }
        public string Password { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
