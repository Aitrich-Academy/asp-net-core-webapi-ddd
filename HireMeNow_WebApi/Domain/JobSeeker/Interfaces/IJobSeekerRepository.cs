
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.JobSeeker.Interfaces
{
    public interface IJobSeekerRepository
    {
        Task<Guid> AddJobseekerSignUpRequest(SignUpRequest jobseekerCreateRequest);
    }
}
