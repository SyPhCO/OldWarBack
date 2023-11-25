using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class Country_Alliance : Identity
    {
        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public long AllianceId { get; set; }
        [ForeignKey("AllianceId")]
        [DataMember]
        public virtual Alliance Alliance { get; set; }
    }
}
