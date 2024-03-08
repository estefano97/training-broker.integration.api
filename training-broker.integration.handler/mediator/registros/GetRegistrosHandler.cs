using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mediator.registros;


internal class GetRegistrosHandler : IRequestHandler<GetRegistrosQuery, GetRegistrosOut>
{
    private readonly TrainingBrokerContext _context;
    private readonly IMapper _mapper;
    
    public GetRegistrosHandler(TrainingBrokerContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<GetRegistrosOut> Handle(GetRegistrosQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var data = await _context.RegistroVariacionStockEmpresas.ToListAsync();
            var parsed = _mapper.Map<List<GetRegistrosOut.RegistrosVariacion>>(data);

            return new GetRegistrosOut { registros = parsed };
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}