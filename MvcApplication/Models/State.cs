//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class State
    {
        public short StateID { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string StateDisplayName { get; set; }
        public short CountryID { get; set; }
        public bool DeletedIndicator { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
