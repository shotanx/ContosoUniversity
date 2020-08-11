using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy - MM - dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
