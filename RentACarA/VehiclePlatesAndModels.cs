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
    
    public partial class VehiclePlatesAndModels
    {
        public int VehicleID { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
    
        public virtual Vehicles Vehicles1 { get; set; }
    }
}
