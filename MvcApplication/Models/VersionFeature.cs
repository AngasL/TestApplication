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
    
    public partial class VersionFeature
    {
        public System.Guid VersionFeatureID { get; set; }
        public int ReleaseNumber { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureDescription { get; set; }
        public string FeaturePath { get; set; }
        public bool DeletedIndicator { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<int> Sequence { get; set; }
        public string LinkTitle { get; set; }
    }
}
