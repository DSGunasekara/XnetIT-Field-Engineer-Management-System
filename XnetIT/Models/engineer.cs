//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XnetIT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class engineer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public engineer()
        {
            this.assign_engineer = new HashSet<assign_engineer>();
            this.eng_ratings = new HashSet<eng_ratings>();
        }
    
        public int e_id { get; set; }
        public string e_name { get; set; }
        public string gov_id { get; set; }
        public string cnumber { get; set; }
        public string email { get; set; }
        public string e_address { get; set; }
        public string skills { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assign_engineer> assign_engineer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<eng_ratings> eng_ratings { get; set; }
    }
}
