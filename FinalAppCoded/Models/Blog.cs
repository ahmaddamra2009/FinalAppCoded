using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalAppCoded.Models
{
    public class Blog
    {   
        public int BlogId { get; set; }
        [Required(ErrorMessage = "Enter Title")]
        public string BlogTitle { get; set; }
        [Required(ErrorMessage = "Enter Desciption")]
        public string BlogDesc { get; set; }
        [Required(ErrorMessage = "Choose Picture")]
        public string BlogImg { get; set; }
        public string Author { get; set; }

        // Relation
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }



    }
}
