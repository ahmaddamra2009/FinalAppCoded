using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using static FinalAppCoded.Models.ENumsList;
namespace FinalAppCoded.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage ="Enter Course Title")]
        [Display(Name ="Course Title")]
        public string CourseTitle { get; set; }
        [Required(ErrorMessage = "Enter Course Descitpion")]
        [Display(Name = "Course Description")]
        [DataType(DataType.MultilineText)]
        public string CourseDesc { get; set; }
        public int Reviews { get; set; }
        [Required(ErrorMessage = "Enter Lessons Number")]
        public int Lessons { get; set; } 
        public decimal Price { get; set; }
        public Durations Duration { get; set; } 
        public Languages Language { get; set; }  
        public string Instructor { get; set; }
        public int Enrolled { get; set; }
        public string VideoUrl { get; set; }

        // Relation
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
