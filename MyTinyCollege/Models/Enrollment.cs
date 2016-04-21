using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTinyCollege.Models
{
    //grade enum
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; } //? in this case means optional

        public virtual Student student { get; set; }
        public virtual Course course { get; set; }
    }
}
