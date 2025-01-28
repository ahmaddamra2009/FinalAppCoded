using System.ComponentModel.DataAnnotations;
using static FinalAppCoded.Models.ENumsList;

namespace FinalAppCoded.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Event Desc")]
        [DataType(DataType.MultilineText)]
        public string EventDesc { get; set; }
        [Required(ErrorMessage = "Select Start Date")]
        [Display(Name ="Select Start Date")]
        [DataType(DataType.Date)]
        public DateTime EventSDate { get; set; }
        [Required(ErrorMessage = "Select End Date")]
        [Display(Name = "Select End Date")]
        [DataType(DataType.Date)]
        public DateTime EventEDate { get; set; }
        [Required(ErrorMessage = "Select Time")]
        [Display(Name = "Select Time")]
        [DataType(DataType.Time)]
        public TimeOnly EventTime { get; set; }
        public Venus Venue { get; set; } //dd
        public decimal Price { get; set; }

    }
}
