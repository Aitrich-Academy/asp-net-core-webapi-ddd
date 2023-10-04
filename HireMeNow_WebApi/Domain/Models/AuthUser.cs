

using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    [Table("AuthUser")]
    public class AuthUser:SystemUser
    {
        [Required]
        public Guid SystemUserId { get; set; }

        [ForeignKey("SystemUserId")] // Specify the foreign key property name
        public SystemUser SystemUser { get; set; }
        public string Password { get; set; }


    }
}
