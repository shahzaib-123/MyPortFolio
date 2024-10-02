using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortFolio.Models
{
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        
        [Required]
        public required string Title { get; set; }

        public string? Description { get; set; }

        public string? Technologies {  get; set; }

        public string? ProjectURL { get; set; }

        public string? ImagePath {  get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

    }
}
