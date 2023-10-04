
using Application.JobSeekerUseCases.Create;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobseekerCreateRequest, SignUpRequest>().ReverseMap();
        }
    }
}
