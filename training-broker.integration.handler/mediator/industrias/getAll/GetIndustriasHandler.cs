using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mediator.industrias.getAll
{
    internal class GetIndustriasHandler : IRequestHandler<GetIndustriasQuery, GetIndustriasOut>
    {

        private readonly TrainingBrokerContext _context;
        private readonly IMapper _mapper;

        public GetIndustriasHandler(TrainingBrokerContext trainingBrokerContext, IMapper mapper)
        {
            _context = trainingBrokerContext;
            _mapper = mapper;
        }

        public async Task<GetIndustriasOut> Handle(GetIndustriasQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var allIndustrias = await _context.Industrias.ToListAsync();
                var parsed = _mapper.Map<List<GetIndustriasOut.Industria>>(allIndustrias);

                return new GetIndustriasOut { industrias = parsed };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
