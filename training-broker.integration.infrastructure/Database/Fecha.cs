using System;
using System.Collections.Generic;

namespace training_broker.integration.infrastructure.Database;

public partial class Fecha
{
    public Guid Id { get; set; }

    public string Valor { get; set; } = null!;

    public DateTime Fecha1 { get; set; }

    public virtual ICollection<RegistroVariacionStockEmpresa> RegistroVariacionStockEmpresas { get; set; } = new List<RegistroVariacionStockEmpresa>();
}
