using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class WorkExperience
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        //[ForeignKey(nameof(JobSeekerProfile))]
        public Guid JobSeekerProfileId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Summary { get; set; }
        public DateTime ServiceStart { get; set; }
        public DateTime ServiceEnd { get; set; }

    }
}