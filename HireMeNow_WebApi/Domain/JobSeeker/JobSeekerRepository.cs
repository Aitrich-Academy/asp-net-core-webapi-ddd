
using Domain.JobSeeker.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.JobSeeker
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        protected readonly ApplicationDbContext _context;
        public JobSeekerRepository(ApplicationDbContext dbContext) {
            _context = dbContext;
        }

        public async Task<Guid> AddJobseekerSignUpRequest(SignUpRequest jobseekerCreateRequest)
        {
          await  _context.SignUpRequest.AddAsync(jobseekerCreateRequest);
          await  _context.SaveChangesAsync();
            return jobseekerCreateRequest.Id;


        }
    }
}
