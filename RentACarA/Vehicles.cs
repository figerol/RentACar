//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicles()
        {
            this.Rents = new HashSet<Rents>();
        }
    
        public int VehicleID { get; set; }
        public string Made { get; set; }
        public string Type { get; set; }
        public Nullable<int> Mileage { get; set; }
        public Nullable<bool> Avalaible { get; set; }
        public string VechNote { get; set; }
        public int Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rents> Rents { get; set; }
        public virtual VehiclePlatesAndModels VehiclePlatesAndModels1 { get; set; }
    }
}
