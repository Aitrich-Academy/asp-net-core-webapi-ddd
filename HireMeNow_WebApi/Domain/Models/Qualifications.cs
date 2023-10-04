using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Qualifications
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        //[ForeignKey(nameof(JobSeekerProfile))]
        public Guid JobSeekerProfileId { get; set; }

        public string? Title { get; set; }

        public string? Mark { get; set; }

        public string? YearOfPassout { get; set; }

        public string? University { get; set; }
    }
}