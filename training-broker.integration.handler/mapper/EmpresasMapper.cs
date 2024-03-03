using AutoMapper;
using training_broker.integration.handler.mediator.empresas.getAll;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mapper
{
    internal class EmpresasMapper : Profile
    {
        public EmpresasMapper() 
        {
            CreateMap<Empresa, GetEmpresasOut.Empresa>();
            CreateMap<GetEmpresasOut.Empresa, Empresa>();
        }
    }
}
