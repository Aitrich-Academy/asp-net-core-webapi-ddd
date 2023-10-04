using Application.AutoMapper;
using Domain.JobSeeker.Interfaces;
using Domain.JobSeeker;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.SignUpRequests;
using Domain.SignUpRequests.Interfaces;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
            services.AddScoped<IJobSeekerService, JobSeekerService>();
            //services.AddMediatR(typeof(myAssemblyStuff).GetTypeInfo().Assembly);

            return services;
        }
    }
}
