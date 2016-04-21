using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTinyCollege.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }

        //fullname is a calculated property that returns a value creted by concatinating two other properties
        //therefore it only has a get accessor and because of this no fullname field will be generated in the database
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}
