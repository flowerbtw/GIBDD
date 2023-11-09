using System;
using System.Collections.Generic;

namespace itogovoe_gibdd;

public partial class RoadAccident
{
    public long Guid { get; set; }

    public string? Class { get; set; }

    public long? Culprit { get; set; }

    public long? Victim { get; set; }

    public virtual DriversCard? CulpritNavigation { get; set; }

    public virtual DriversCard? VictimNavigation { get; set; }
}
