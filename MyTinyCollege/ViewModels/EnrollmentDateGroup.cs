﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTinyCollege.ViewModels
{
    class EnrollmentDateGroup
    {

        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int StudentCount { get; set; }

    }
}
