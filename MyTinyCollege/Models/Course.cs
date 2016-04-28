using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTinyCollege.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength =3)]
        public string Title { get; set; }

        [Range(0,5)] //Credits can be between 0 and 5 - validated in front end
        public int Credits { get; set; }
        public int DepartmentID { get; set; }//FK to department


        //================== Navigation properties =======================

        //1 course to many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //1 course to many instructors
        public virtual ICollection<Instructor> Instructors { get; set; }

        //course belongs to a department
        public virtual Department Department { get; set; }

        //Combine the CourseID and title in on property
        public string CourseIdTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }

    }

}