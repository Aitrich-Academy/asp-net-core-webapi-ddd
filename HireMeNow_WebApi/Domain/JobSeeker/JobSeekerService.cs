﻿
using AutoMapper;
using Domain.JobSeeker.Interfaces;
using Domain.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.JobSeeker
{
    public class JobSeekerService : IJobSeekerService
    {
        public IJobSeekerRepository _repository;
        public IMapper _mapper;
        public EmailService _emailService;
        public JobSeekerService(IJobSeekerRepository Repo, IMapper mapper,EmailService emailService) { 
        _repository = Repo;
            _mapper=mapper;
            _emailService=emailService;
        }

        public async Task AddJobseekerSignUpRequest(SignUpRequest data)
        {
            var reqstId = await _repository.AddJobseekerSignUpRequest(data);
            if(reqstId!=null)
            {
                _emailService.SendJobseekerVerificationEmail(reqstId);
            }
            //throw new NotImplementedException();
        }
        //public async Task Register(JobseekerCreateRequest jobseekerCreateRequest)
        //{
        //    //Guid regid =await _repository.AddJobseekerSignUpRequest();
        //}
    }
}
