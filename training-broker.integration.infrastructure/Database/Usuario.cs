using System;
using System.Collections.Generic;

namespace training_broker.integration.infrastructure.Database;

public partial class Usuario
{
    public Guid Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Celular { get; set; } = null!;
}
