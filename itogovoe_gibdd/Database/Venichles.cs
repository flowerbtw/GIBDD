using System;
using System.Collections.Generic;

namespace itogovoe_gibdd.Database;

public partial class Venichles
{
    public string Vin { get; set; } = null!;

    public long? Owner { get; set; }

    public string? Mark { get; set; }

    public string? Model { get; set; }

    public string? Type { get; set; }

    public string? Category { get; set; }

    public string? Color { get; set; }

    public long? Power { get; set; }

    public virtual DriversCards? OwnerNavigation { get; set; }
}
