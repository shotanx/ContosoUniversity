using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Title { get; set; }

        [Range(4, 7)]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
