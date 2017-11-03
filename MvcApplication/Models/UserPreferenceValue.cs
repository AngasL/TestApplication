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
    
    public partial class UserPreferenceValue
    {
        public System.Guid UserPreferenceID { get; set; }
        public int FirmID { get; set; }
        public int PreferenceID { get; set; }
        public System.Guid UserID { get; set; }
        public short SequenceNumber { get; set; }
        public string PreferenceValue { get; set; }
        public short ApplicationID { get; set; }
        public bool DeletedIndicator { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string PreferenceKey { get; set; }
    
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual Preference Preference { get; set; }
    }
}
