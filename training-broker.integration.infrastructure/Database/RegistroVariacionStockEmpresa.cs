using System;
using System.Collections.Generic;

namespace training_broker.integration.infrastructure.Database;

public partial class RegistroVariacionStockEmpresa
{
    public Guid Id { get; set; }

    public string Emisor { get; set; } = null!;

    public decimal ValorNominalUnitario { get; set; }

    public decimal? PrecioUltimasSemanasAlto { get; set; }

    public decimal? PrecioUltimasSemanasBajo { get; set; }

    public decimal UltimoPrecio { get; set; }

    public decimal PrecioUnitarioVeces { get; set; }

    public string Dpyield { get; set; } = null!;

    public decimal ValorCapMilesUsd { get; set; }

    public decimal Pvl { get; set; }

    public string PresenciaBursatil { get; set; } = null!;

    public decimal IndiceRotacion { get; set; }

    public string ActualizacionDeInfoFinanciera { get; set; } = null!;

    public string Industria { get; set; } = null!;

    public string Fecha { get; set; } = null!;

    public Guid IdIndustria { get; set; }

    public Guid IdFecha { get; set; }

    public Guid IdEmpresa { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Fecha IdFechaNavigation { get; set; } = null!;

    public virtual Industria IdIndustriaNavigation { get; set; } = null!;
}
