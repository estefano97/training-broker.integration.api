using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mediator.registrosVariacion.getByEmpresa;


internal class GetRegistrosVariacionHandler : IRequestHandler<GetRegistrosVariacionQuery, GetRegistrosVariacionOut>
{
    private readonly TrainingBrokerContext _context;
    private readonly IMapper _mapper;

    public GetRegistrosVariacionHandler(TrainingBrokerContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetRegistrosVariacionOut> Handle(GetRegistrosVariacionQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var enterpriseInfo = await _context.Empresas.Where(data => data.Id == request.IdEmpresa).FirstOrDefaultAsync() ?? throw new ArgumentNullException("IdEmpresa doesnt exists");
            var data = await _context.RegistroVariacionStockEmpresas.Include(d => d.IdFechaNavigation).Where(el => el.IdEmpresa == request.IdEmpresa).OrderBy(d => d.IdFechaNavigation.Fecha1).ToListAsync();
            var parsed = _mapper.Map<List<GetRegistrosVariacionOut.RegistrosVariacion>>(data);

            return new GetRegistrosVariacionOut { registros = parsed, Emisor = enterpriseInfo.Name, IdIndustria = enterpriseInfo.IdIndustria };
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}