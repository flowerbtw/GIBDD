using System;
using System.Collections.Generic;

namespace itogovoe_gibdd;

public partial class DriversCard
{
    public long Guid { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Passport { get; set; }

    public string? RegistrationAddress { get; set; }

    public string? ResidentialAddress { get; set; }

    public string? Company { get; set; }

    public string? Jobname { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<DriversLicense> DriversLicenses { get; set; } = new List<DriversLicense>();

    public virtual ICollection<Penalty> Penalties { get; set; } = new List<Penalty>();

    public virtual ICollection<RoadAccident> RoadAccidentCulpritNavigations { get; set; } = new List<RoadAccident>();

    public virtual ICollection<RoadAccident> RoadAccidentVictimNavigations { get; set; } = new List<RoadAccident>();

    public virtual ICollection<Venichle> Venichles { get; set; } = new List<Venichle>();
}
