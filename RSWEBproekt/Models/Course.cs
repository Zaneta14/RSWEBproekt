using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEBproekt.Models
{
    public class Course
    { 
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required, Range(2, 7)]
        public int Credits { get; set; }

        [Required, Range(1, 8)]
        public int Semestar { get; set; }

        [StringLength(100)]
        public string Programme { get; set; }

        [StringLength(25)]
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }

        
        public int? FirstTeacherId { get; set; }
        [Display(Name = "First Teacher")]
        public Teacher FirstTeacher { get; set; }

        public int? SecondTeacherId { get; set; }
        [Display(Name = "Second Teacher")]
        public Teacher SecondTeacher { get; set; }

        public ICollection<Enrollment> Students { get; set; }
    }
}
