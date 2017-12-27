//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSI.StudentManagement.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enquiry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enquiry()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public string EnquiryID { get; set; }
        public string EnquiryType { get; set; }
        public Nullable<long> ReferenceID { get; set; }
        public long CourseID1 { get; set; }
        public Nullable<long> CourseID2 { get; set; }
        public Nullable<long> CourseID3 { get; set; }
        public Nullable<int> ExpectedCourseDuration { get; set; }
        public string CounsellorName { get; set; }
        public Nullable<System.DateTime> ExpectedDOJ { get; set; }
        public Nullable<System.TimeSpan> ConvenientTimings { get; set; }
        public Nullable<long> EnquiryStatusID { get; set; }
        public string AdditionalInfo { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string StudentID { get; set; }
    
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
