//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_Data.BT_EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class bt_College
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bt_College()
        {
            this.bt_CollegeBranches = new HashSet<bt_CollegeBranches>();
            this.bt_CollegeBranches1 = new HashSet<bt_CollegeBranches>();
            this.bt_CollegeDirector = new HashSet<bt_CollegeDirector>();
        }
    
        public System.Guid CollegeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> AddressId { get; set; }
        public Nullable<System.Guid> DirectorId { get; set; }
    
        public virtual bt_Address bt_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_CollegeBranches> bt_CollegeBranches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_CollegeBranches> bt_CollegeBranches1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_CollegeDirector> bt_CollegeDirector { get; set; }
    }
}
