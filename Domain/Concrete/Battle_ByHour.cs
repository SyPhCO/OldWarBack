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
    public class Battle_ByHour : Identity
    {
        public long BattleId { get; set; }
        [ForeignKey("BattleId")]
        public virtual Battle Battle { get; set; }

        public long ByHourId { get; set; }
        [ForeignKey("ByHourId")]
        [DataMember]
        public virtual ByHour ByHour { get; set; }
    }
}
