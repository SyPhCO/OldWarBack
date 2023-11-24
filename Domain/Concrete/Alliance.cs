using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Alliance : Identity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalAllianceSoldier { get; set; }
        public string Flag { get; set; }
        public List<Alliance> Alliance_Categories { get; set; }
        public Alliance() {
            Alliance_Categories = new();
        }
    }
}
