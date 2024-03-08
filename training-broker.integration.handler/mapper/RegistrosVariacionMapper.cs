using AutoMapper;
using training_broker.integration.handler.mediator.registrosVariacion.getByEmpresa;
using training_broker.integration.infrastructure.Database;


namespace training_broker.integration.handler.mapper;

public class RegistrosVariacionMapper : Profile
{
    public RegistrosVariacionMapper() 
    {
        CreateMap<RegistroVariacionStockEmpresa, GetRegistrosVariacionOut.RegistrosVariacion>()
        .ForPath(dest => dest.Fecha, opt => opt.MapFrom(src => src.IdFechaNavigation.Fecha1));
        CreateMap<GetRegistrosVariacionOut.RegistrosVariacion, RegistroVariacionStockEmpresa>()
            .ForPath(dest => dest.IdFechaNavigation.Fecha1, opt => opt.MapFrom(src => src.Fecha));
    }
}













