using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training_broker.integration.handler.mediator.empresas;
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
