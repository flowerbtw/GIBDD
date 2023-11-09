using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogovoe_gibdd.Database
{
    public class DriversLicenses
    {
        public string Number { get; set; }
        public int Owner { get; set; }
        public string DateOfIssue { get; set; }
        public string DateOfExpiry { get; set; }
        public string WhoIssued { get; set; }
        public string Category { get; set; }
    }
}
