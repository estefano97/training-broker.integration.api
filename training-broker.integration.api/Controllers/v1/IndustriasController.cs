using MediatR;
using Microsoft.AspNetCore.Mvc;
using training_broker.integration.api.Controllers.v1._base;
using training_broker.integration.handler.mediator.industrias;

namespace training_broker.integration.api.Controllers.v1
{
    public class IndustriasController : V1BaseController
    {
        public IndustriasController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllIndustrias()
        {
            try
            {
                var response = await _mediator.Send(new GetIndustriasQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
