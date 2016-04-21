using System.Collections;
using System.Collections.Generic;

namespace MyTinyCollege.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }//FK to department

        //Navigation
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual Department Department { get; set; }

        public string CourseIdTitle
        {
            get
            {
                return CourseID + ", " + Title;
            }
        }
    }
}