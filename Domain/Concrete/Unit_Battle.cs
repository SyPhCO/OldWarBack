using Domain.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    public class Unit_Battle : Identity
    {
        public long UnitId { get; set; }
        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }

        public long BattleId { get; set; }
        [ForeignKey("BattleId")]
        [DataMember]
        public virtual Battle Battle { get; set; }
    }
}
