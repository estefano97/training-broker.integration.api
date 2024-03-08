using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using training_broker.integration.handler.mediator.industrias;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.handler.mapper
{
    internal class IndustriasMapper : Profile
    {
        public IndustriasMapper()
        {
            CreateMap<Industria, GetIndustriasOut.Industria>();
            CreateMap<GetIndustriasOut.Industria, Industria>();
        }
    }
}











