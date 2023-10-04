
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SignUpRequests.Interfaces
{
    public interface ISignUpRequestRepository
    {
        Task<Guid> AddJobseekerSignUpRequest(SignUpRequest jobseekerCreateRequest);
    }
}
