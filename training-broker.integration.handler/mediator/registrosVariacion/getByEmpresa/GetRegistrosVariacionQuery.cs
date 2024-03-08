using MediatR;

namespace training_broker.integration.handler.mediator.registrosVariacion.getByEmpresa;

public class GetRegistrosVariacionQuery : IRequest<GetRegistrosVariacionOut>
{
    public Guid IdEmpresa { get; set; }
}