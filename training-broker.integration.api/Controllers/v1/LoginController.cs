using MediatR;
using Microsoft.AspNetCore.Mvc;
using training_broker.integration.api.Controllers.v1._base;
using training_broker.integration.handler.mediator.authentication;
using training_broker.integration.handler.mediator.authentication.login;

namespace training_broker.integration.api.Controllers.v1;

public class LoginController : V1BaseController
{
    public LoginController(IMediator mediator) : base(mediator)
    {
    }
    [HttpPost("login")]
    public async Task<IActionResult> LoginAuth([FromBody]LoginRequest request)
    {
        try
        {
            var response = await _mediator.Send(new LoginAuthQuery() { Email = request.Email, Password = request.Password });
            return Ok(response);
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
    }


}