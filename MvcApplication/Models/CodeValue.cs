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
    
    public partial class CodeValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeValue()
        {
            this.ApplicationUser = new HashSet<ApplicationUser>();
            this.BillingCodeSet = new HashSet<BillingCodeSet>();
            this.BillingCodeSet1 = new HashSet<BillingCodeSet>();
            this.WamApplicationUser = new HashSet<WamApplicationUser>();
        }
    
        public int CodeValueID { get; set; }
        public short CodeTypeID { get; set; }
        public string CodeValueName { get; set; }
        public string CodeValueDisplayName { get; set; }
        public string ConstantLookupValue { get; set; }
        public short SequenceNumber { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public bool DeletedIndicator { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingCodeSet> BillingCodeSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingCodeSet> BillingCodeSet1 { get; set; }
        public virtual CodeType CodeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WamApplicationUser> WamApplicationUser { get; set; }
    }
}
