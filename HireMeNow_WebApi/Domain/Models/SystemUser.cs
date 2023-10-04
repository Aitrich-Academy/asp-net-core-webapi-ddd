using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class SystemUser
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
      
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}
