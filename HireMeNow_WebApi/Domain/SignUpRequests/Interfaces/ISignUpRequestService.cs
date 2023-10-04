
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SignUpRequests.Interfaces
{
    public interface ISignUpRequestService
    {
        //Task Register(JobseekerCreateRequest jobseekerCreateRequest);
      public  Task AddJobseekerSignUpRequest(SignUpRequest data);
    }
}
