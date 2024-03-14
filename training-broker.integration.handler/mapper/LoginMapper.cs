using AutoMapper;
using training_broker.integration.handler.mediator.authentication.login;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mapper;

public class LoginMapper : Profile
{
    public LoginMapper()
    {
        CreateMap<Usuario, LoginAuthOut>();
        CreateMap<LoginAuthOut, Usuario>();
    }
}