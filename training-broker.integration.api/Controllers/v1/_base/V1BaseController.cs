using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace training_broker.integration.api.Controllers.v1._base
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class V1BaseController : ControllerBase
    {
        protected V1BaseController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        protected IMediator _mediator { get; }
    }
}
