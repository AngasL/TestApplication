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
    
    public partial class CodeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CodeType()
        {
            this.CodeValue = new HashSet<CodeValue>();
            this.Preference = new HashSet<Preference>();
        }
    
        public short CodeTypeID { get; set; }
        public string CodeTypeName { get; set; }
        public byte[] RowChangeTimestamp { get; set; }
        public bool DeletedIndicator { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeValue> CodeValue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Preference> Preference { get; set; }
    }
}