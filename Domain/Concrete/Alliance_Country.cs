using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Alliance_Country : Identity
    {           
        public long AllianceId { get; set; }
        [ForeignKey("AllianceId")]
        public virtual Alliance Alliance { get; set; }
        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public List<Alliance_Country> Alliance_Country_Categories { get; set; }
        public Alliance_Country()
        {
            Alliance_Country_Categories = new();
        }
    }
}

