//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsFacility4A
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability
    {
        public int VenueID { get; set; }
        public Nullable<bool> C9am { get; set; }
        public Nullable<bool> C10am { get; set; }
        public Nullable<bool> C11am { get; set; }
        public Nullable<bool> C12pm { get; set; }
        public Nullable<bool> C1pm { get; set; }
        public Nullable<bool> C2pm { get; set; }
        public Nullable<bool> C3pm { get; set; }
        public Nullable<bool> C4pm { get; set; }
        public Nullable<bool> C5pm { get; set; }
    
        public virtual Venue Venue { get; set; }
    }
}
