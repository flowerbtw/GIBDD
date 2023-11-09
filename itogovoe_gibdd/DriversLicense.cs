using System;
using System.Collections.Generic;

namespace itogovoe_gibdd;

public partial class DriversLicense
{
    public string Number { get; set; } = null!;

    public long? Owner { get; set; }

    public string? DateOfIssue { get; set; }

    public string? DateOfExpiry { get; set; }

    public string? WhoIssued { get; set; }

    public string? Category { get; set; }

    public virtual DriversCard? OwnerNavigation { get; set; }
}
