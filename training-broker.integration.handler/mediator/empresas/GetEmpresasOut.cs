using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_broker.integration.handler.mediator.empresas
{
    public class GetEmpresasOut
    {
        public class Empresa
        {
            public Guid Id { get; set; }

            public string Name { get; set; } = null!;

            public string? Image { get; set; }

            public Guid IdIndustria { get; set; }
        }

        public List<Empresa> empresas { get; set; }
    }
}
