using Application.JobSeekerUseCases.Create;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.JobSeekerUseCases.Create
{
    public class JobseekerCreateCommand: IRequest
    {
        public JobseekerCreateRequest Model;
        public JobseekerCreateCommand(JobseekerCreateRequest _model) {
        this.Model = _model;
        }
    }
}
