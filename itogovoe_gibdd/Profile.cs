using System;
using System.Collections.Generic;

namespace itogovoe_gibdd;

public partial class Profile
{
    public long Guid { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Patronymic { get; set; }

    public string? Passport { get; set; }

    public string? Rank { get; set; }

    public string? Badge { get; set; }

    public string? RegistrationAddress { get; set; }

    public string? ResidentialAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? VacationDates { get; set; }
}
