using AutoMapper;
using training_broker.integration.handler.mediator.empresas.getAll;
using training_broker.integration.handler.mediator.registros;
using training_broker.integration.infrastructure.Database;


namespace training_broker.integration.handler.mapper;

public class RegistrosVariacionMapper : Profile
{
    public RegistrosVariacionMapper() 
    {
        CreateMap<RegistroVariacionStockEmpresa, GetRegistrosOut.RegistrosVariacion>();
        CreateMap<GetRegistrosOut.RegistrosVariacion, RegistroVariacionStockEmpresa>();
    }
}













