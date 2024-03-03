using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mediator.empresas.getAll
{
    internal class GetEmpresasHandler : IRequestHandler<GetEmpresasQuery, GetEmpresasOut>
    {

        private readonly TrainingBrokerContext _context;
        private readonly IMapper _mapper;

        public GetEmpresasHandler(TrainingBrokerContext trainingBrokerContext, IMapper mapper)
        {
            _context = trainingBrokerContext;
            _mapper = mapper;
        }

        public async Task<GetEmpresasOut> Handle(GetEmpresasQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _context.Empresas.ToListAsync();
                var parsed = _mapper.Map<List<GetEmpresasOut.Empresa>>(data);

                return new GetEmpresasOut { empresas = parsed };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
