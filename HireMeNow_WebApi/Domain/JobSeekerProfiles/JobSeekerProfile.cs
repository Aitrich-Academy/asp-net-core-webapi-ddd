using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Domain.JobSeekerProfiles
{
    public class JobSeekerProfile
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ResumeId { get; set; }
        public string? ProfileName { get; set; }
        public string? ProfileSummary { get; set; }

        // Navigational Properties
        public virtual Resume? Resume { get; set; }
        [ForeignKey("JobSeekerProfileId")]
        public virtual ICollection<Qualifications>? Qualifications { get; set; }
        [ForeignKey("JobSeekerProfileId")]
        public virtual ICollection<WorkExperience>? WorkExperiences { get; set; }
        [ForeignKey("Id")]
        public virtual ICollection<Skill>? Skills { get; set; }

    }
}
