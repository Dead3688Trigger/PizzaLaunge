//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        public string Cus_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Order_ID { get; set; }
        public string Payment_ID { get; set; }
    
        public virtual ORDER ORDER { get; set; }
        public virtual PAYMENT PAYMENT { get; set; }
    }
}