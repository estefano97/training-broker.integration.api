using MediatR;

namespace training_broker.integration.handler.mediator.registros;

public class GetRegistrosQuery : IRequest<GetRegistrosOut>
{
    public Guid IdEmpresa { get; set; }
}