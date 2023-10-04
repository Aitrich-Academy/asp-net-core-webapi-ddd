using Domain.JobSeekerProfiles;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ApplicationDbContext: DbContext
    {
     

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AuthUser> AuthUser { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }
        public virtual DbSet<JobSeeker.JobSeeker> JobSeeker { get; set; }
        public virtual DbSet<JobSeekerProfile> JobSeekerProfile { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Qualifications> Qualifications { get; set; }
        public virtual DbSet<WorkExperience> Experiences { get; set; }
        public virtual DbSet<SignUpRequest> SignUpRequest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobSeeker.JobSeeker>()
                .HasOne(js => js.SystemUser)
                .WithMany()
                .HasForeignKey(js => js.SystemUserId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete
            modelBuilder.Entity<AuthUser>()
             .HasOne(js => js.SystemUser)
             .WithMany()
             .HasForeignKey(js => js.SystemUserId)
             .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete
        }
    }
}
