//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemPart()
        {
            this.UserAccess = new HashSet<UserAccess>();
        }
    
        public int SystemPartID { get; set; }
        public string SystemPartName { get; set; }
        public string SystemPartDeatiles { get; set; }
        public Nullable<int> SystemPartLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAccess> UserAccess { get; set; }
    }
}
