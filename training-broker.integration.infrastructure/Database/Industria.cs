using System;
using System.Collections.Generic;

namespace training_broker.integration.infrastructure.Database;

public partial class Industria
{
    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<RegistroVariacionStockEmpresa> RegistroVariacionStockEmpresas { get; set; } = new List<RegistroVariacionStockEmpresa>();
}
