using MediatR;

namespace training_broker.integration.handler.mediator.authentication.login;

public class LoginAuthQuery : IRequest<LoginAuthOut>
{
    public string Email { get; set; }
    public string Password { get; set; }

}