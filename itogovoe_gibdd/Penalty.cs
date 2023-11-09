using System;
using System.Collections.Generic;

namespace itogovoe_gibdd;

public partial class Penalty
{
    public long Guid { get; set; }

    public long? Recipient { get; set; }

    public string? Photo { get; set; }

    public virtual DriversCard? RecipientNavigation { get; set; }
}
