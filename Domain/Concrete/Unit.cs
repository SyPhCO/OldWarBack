using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Unit : Identity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? ChargeMusic { get; set; }
        public List<Unit> Unit_Categories { get; set; }
        public Unit()
        {
            Unit_Categories = new();
        }
    }
}
