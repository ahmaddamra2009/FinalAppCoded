using System.ComponentModel.DataAnnotations;

namespace FinalAppCoded.Models
{
    public class Category
    {
        public int CategoryId { get; set; } 
        [Required(ErrorMessage ="Enter Category Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Enter Category Description")]
        [MaxLength(15)]
        public string? Description { get; set; }
        public string? CategoryImg { get; set; }
    }
}
