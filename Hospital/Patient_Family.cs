//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient_Family
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient_Family()
        {
            this.Patients = new HashSet<Patient>();
        }
    
        public int id { get; set; }
        public string full_name { get; set; }
        public bool gender_type { get; set; }
        public int state_of_origin_id { get; set; }
        public string phone { get; set; }
        public string adress { get; set; }
        public string relitionship_with_patient { get; set; }
        public bool same_as_patient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual State_of_Origin State_of_Origin { get; set; }
    }
}