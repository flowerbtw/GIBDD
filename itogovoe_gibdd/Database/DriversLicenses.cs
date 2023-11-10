using System;
using System.Collections.Generic;

namespace itogovoe_gibdd.Database;

public partial class DriversLicenses
{
    public string Number { get; set; } = null!;

    public long? Owner { get; set; }

    public string? DateOfIssue { get; set; }

    public string? DateOfExpiry { get; set; }

    public string? WhoIssued { get; set; }

    public string? WhereIssued { get; set; }

    public string? Category { get; set; }

    public string? Status { get; set; }

    public virtual DriversCards? OwnerNavigation { get; set; }
}
