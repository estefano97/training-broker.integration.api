
namespace training_broker.integration.handler.mediator.registros;

public class GetRegistrosOut
{
    public class RegistrosVariacion
    {
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
    }
    
    public List<RegistrosVariacion> registros { get; set; }
}