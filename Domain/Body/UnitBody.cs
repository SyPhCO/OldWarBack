using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Body
{
    public class UnitBody
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ChargeMusic { get; set; }
        public long Rank { get; set; }
        public long Category { get; set; }
        public long Country { get; set; }
        public long Faction { get; set; }
    }
}
