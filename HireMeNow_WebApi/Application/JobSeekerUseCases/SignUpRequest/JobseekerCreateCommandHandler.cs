using AutoMapper;
using Domain.JobSeeker;
using Domain.JobSeeker.Interfaces;
using Domain.Models;
using Domain.SignUpRequests.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobSeekerUseCases.Create
{
    public class JobseekerCreateCommandHandler : IRequestHandler<JobseekerCreateCommand>
    {
        public ISignUpRequestService _signUpService;
        IMapper _mapper;
        public JobseekerCreateCommandHandler(ISignUpRequestService signUpService, IMapper mapper)
        {
            _signUpService= signUpService;
            _mapper= mapper;
        }
        public async Task<Unit> Handle(JobseekerCreateCommand request, CancellationToken cancellationToken)
        {
            var data= _mapper.Map<SignUpRequest>(request.Model);
            await _signUpService.AddJobseekerSignUpRequest(data);
            return Unit.Value;
           //throw new NotImplementedException();
        }
    }
}
