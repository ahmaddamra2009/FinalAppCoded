using System.ComponentModel.DataAnnotations;

namespace FinalAppCoded.Models
{
    public class Menu
    {

        public int MenuId { get; set; }
        [Required(ErrorMessage ="Enter Title")]
        [Display(Name = "Title")]
        public string MenuTitle { get; set; }
        [Required(ErrorMessage = "Enter Url")]
        [Display(Name = "Title URL")]
        public string TitleUrl { get; set; }
        [Required(ErrorMessage = "Select Parent")]
        [Display(Name = "Select Parent")]

        public int? ParentId { get; set; }
    }
}
