//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProCSharpSample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int Id { get; set; }
        public System.DateTime ReservationFrom { get; set; }
        public System.DateTime ReservationTo { get; set; }
        public string Contact { get; set; }
        public int RoomId { get; set; }
    
        public virtual MeetingRoom MeetingRoom { get; set; }
    }
}
