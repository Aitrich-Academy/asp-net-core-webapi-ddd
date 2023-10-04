using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Domain.JobSeeker
{
    [Table("JobSeeker")]
    public class JobSeeker : SystemUser
    {
        [Required]
        public Guid SystemUserId { get; set; }

        [ForeignKey("SystemUserId")] // Specify the foreign key property name
        public SystemUser SystemUser { get; set; }

    }
}
