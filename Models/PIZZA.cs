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
    
    public partial class PIZZA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PIZZA()
        {
            this.TOPPINGS = new HashSet<TOPPING>();
        }
    
        public string Pizza_ID { get; set; }
        public string Pizza_Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Order_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOPPING> TOPPINGS { get; set; }
        public virtual ORDER ORDER { get; set; }
    }
}
