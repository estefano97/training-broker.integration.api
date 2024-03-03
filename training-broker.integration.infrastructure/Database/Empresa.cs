using System;
using System.Collections.Generic;

namespace training_broker.integration.infrastructure.Database;

public partial class Empresa
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public Guid IdIndustria { get; set; }

    public virtual ICollection<RegistroVariacionStockEmpresa> RegistroVariacionStockEmpresas { get; set; } = new List<RegistroVariacionStockEmpresa>();
}
