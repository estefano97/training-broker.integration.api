
namespace training_broker.integration.handler.mediator.industrias
{
    public class GetIndustriasOut
    {
        public class Industria
        {
            public Guid Id { get; set; }
            public string Nombre { get; set; } = null!;
        }

        public List<Industria> industrias { get; set; }
    }
}
