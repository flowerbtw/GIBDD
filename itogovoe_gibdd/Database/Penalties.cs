using System;
using System.Collections.Generic;

namespace itogovoe_gibdd.Database;

public partial class Penalties
{
    public long Guid { get; set; }

    public long? Recipient { get; set; }

    public string? Photo { get; set; }

    public virtual DriversCards? RecipientNavigation { get; set; }
}
