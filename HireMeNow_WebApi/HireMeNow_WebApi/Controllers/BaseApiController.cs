using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_WebApi.Controllers
{
    [Route("api/v1")]
    public abstract class BaseApiController<T> : ControllerBase
    {
        private IMediator _mediatorInstance;
        //private ILogger<T> _loggerInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();
        //protected ILogger<T> _log => _loggerInstance ??= HttpContext.RequestServices.GetService<ILogger<T>>();
    }
}
