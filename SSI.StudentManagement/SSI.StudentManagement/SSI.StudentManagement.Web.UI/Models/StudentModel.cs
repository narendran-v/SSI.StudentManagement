using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSI.StudentManagement.Web.UI.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            qualification = new QualificationModel();
        }
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CertificateName { get; set; }
        public DateTime DOB { get; set; } 
        public int Age { get; set; }
        public string ContactNumber { get; set; }
        public string AlternateNumber { get; set; }
        public string Email { get; set; }
        public QualificationModel qualification { get; set; }

    }
}
