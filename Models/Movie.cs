using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//This model pulls the input data from the user from the movie form
namespace Assignment9.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}

