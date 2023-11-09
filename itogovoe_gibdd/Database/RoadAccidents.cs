using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogovoe_gibdd.Database
{
    public class RoadAccidents
    {
        public int GUID { get; set; }
        public string Class { get; set; }
        public int Culprit { get; set; }
        public int Victim { get; set; }
    }
}
