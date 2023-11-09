using System;
using System.Collections.Generic;

namespace itogovoe_gibdd.Database;

public partial class RoadAccidents
{
    public long Guid { get; set; }

    public string? Class { get; set; }

    public long? Culprit { get; set; }

    public long? Victim { get; set; }

    public virtual DriversCards? CulpritNavigation { get; set; }

    public virtual DriversCards? VictimNavigation { get; set; }
}
