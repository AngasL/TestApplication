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
    
    public partial class PreferenceValue
    {
        public System.Guid PreferenceValueID { get; set; }
        public Nullable<int> FirmID { get; set; }
        public int PreferenceID { get; set; }
        public short SequenceNumber { get; set; }
        public string PreferenceValue1 { get; set; }
        public bool DeletedIndicator { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Firm Firm { get; set; }
        public virtual Preference Preference { get; set; }
    }
}
