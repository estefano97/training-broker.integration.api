using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mediator.authentication.login;

internal class LoginAuthHandler : IRequestHandler<LoginAuthQuery, LoginAuthOut>
{
    private readonly TrainingBrokerContext _context;
        private readonly IMapper _mapper;

        public LoginAuthHandler(TrainingBrokerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<LoginAuthOut> Handle(LoginAuthQuery request, CancellationToken cancellationToken)
        {
            try
            {
                Usuario? data = await _context.Usuarios.FirstOrDefaultAsync(el => el.Email == request.Email && el.Password == request.Password);
        
                if (data == null)
                {
                    // Usuario no encontrado
                    return new LoginAuthOut();
                }

                var parsed = _mapper.Map<LoginAuthOut>(data);
                return parsed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

}