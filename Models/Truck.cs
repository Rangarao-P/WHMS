//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WHMS_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Truck
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Truck()
        {
            this.Logistics = new HashSet<Logistic>();
        }
    
        public int TruckId { get; set; }
        public int TruckNumber { get; set; }
        public int MaxLoad { get; set; }
        public Nullable<bool> assigned { get; set; }
        public Nullable<bool> loaded { get; set; }
        public Nullable<bool> completed { get; set; }
        public string loadNature { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Logistic> Logistics { get; set; }
    }
}
