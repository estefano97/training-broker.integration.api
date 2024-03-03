using MediatR;
using Microsoft.AspNetCore.Mvc;
using training_broker.integration.api.Controllers.v1._base;
using training_broker.integration.handler.mediator.empresas.getAll;

namespace training_broker.integration.api.Controllers.v1
{
    public class EmpresasController : V1BaseController
    {
        public EmpresasController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("healthcheck")]
        public IActionResult HealthCheck()
        {
            return Ok("Funcionando!");
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllEmpresas()
        {
            try
            {
                var response = await _mediator.Send(new GetEmpresasQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
