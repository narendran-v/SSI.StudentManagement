using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSI.StudentManagement.Web.UI.Models
{
    public class EnquiryModel
    {
        public EnquiryModel()
        {
            Student = new StudentModel();
        }
        public string EnquiryId { get; set; }
        public string EnquiryType { get; set; }
        public string ReferenceId { get; set; }
        public string CourseId1 { get; set; }
        public string CourseId2 { get; set; }
        public string CourseId3 { get; set; }
        public int ExpectedCourseDuration { get; set; }
        public string CousellorName { get; set; }
        public DateTime ExpectedDOJ { get; set; }
        public string ConvenientTimings { get; set; }
        public string EnquiryStatus { get; set; }
        public string AdditionalInfo { get; set; }
        public StudentModel Student { get; set; }
        }

    }