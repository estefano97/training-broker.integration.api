
using MediatR;
using Microsoft.AspNetCore.Mvc;
using training_broker.integration.api.Controllers.v1._base;
using training_broker.integration.handler.mediator.registrosVariacion.getByEmpresa;

namespace training_broker.integration.api.Controllers.v1
{
    
    public class RegistrosVariacionController : V1BaseController
    {
        public RegistrosVariacionController(IMediator mediator) : base(mediator)
        {
        }
        

        [HttpGet("general/{idEmpresa}")]
        public async Task<IActionResult> GetAllRegistros([FromRoute]Guid idEmpresa)
        {
            try
            {
                var response = await _mediator.Send(new GetRegistrosVariacionQuery() { IdEmpresa = idEmpresa});
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
