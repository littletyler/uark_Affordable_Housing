//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventHistory
    {
        public int EventID { get; set; }
        public System.DateTime ActionDate { get; set; }
        public int UserID { get; set; }
        public string ActionType { get; set; }
        public string StreetAddr { get; set; }
        public string City { get; set; }
        public string StateAbbr { get; set; }
        public int Zip { get; set; }
        public string County { get; set; }
    }
}
