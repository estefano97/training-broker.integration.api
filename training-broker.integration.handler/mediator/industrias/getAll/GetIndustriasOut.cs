namespace training_broker.integration.handler.mediator.industrias.getAll
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
