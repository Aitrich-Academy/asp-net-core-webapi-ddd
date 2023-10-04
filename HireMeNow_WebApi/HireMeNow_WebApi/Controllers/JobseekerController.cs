
using Application.JobSeekerUseCases.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_WebApi.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class JobseekerController : BaseApiController<JobseekerController>
    {
        [HttpPost]
        [Route("job-seeker/signup")]
        public async Task<ActionResult> create(JobseekerCreateRequest data)
        {
            //_log.LogDebug("REST request create ScannedWord");
            var dtos = await _mediator.Send(new JobseekerCreateCommand(data));
            return Ok(dtos);
        }
    }
}
