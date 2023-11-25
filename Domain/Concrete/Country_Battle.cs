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
    public class Country_Battle : Identity
    {
        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public long BattleId { get; set; }
        [ForeignKey("BattleId")]
        [DataMember]
        public virtual Battle Battle { get; set; }
    }
}
