using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using itogovoe_gibdd.Database;

namespace itogovoe_gibdd;

public partial class DriversCards
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

    public virtual ICollection<DriversLicenses> DriversLicenses { get; set; } = new List<DriversLicenses>();

    public virtual ICollection<Penalties> Penalties { get; set; } = new List<Penalties>();

    public virtual ICollection<RoadAccidents> RoadAccidentCulpritNavigations { get; set; } = new List<RoadAccidents>();

    public virtual ICollection<RoadAccidents> RoadAccidentVictimNavigations { get; set; } = new List<RoadAccidents>();

    public virtual ICollection<Venichles> Venichles { get; set; } = new List<Venichles>();
}
