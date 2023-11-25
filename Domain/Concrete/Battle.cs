using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    [DataContract]
    public class Battle : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Genesis { get; set; }

        [DataMember]
        public DateTime BattleStart { get; set; }

        [DataMember]
        public DateTime BattleEnd { get; set; }

        [DataMember]
        public GlobalWar GlobalWar { get; set; }

        [DataMember]
        public ICollection<Country_Battle> Country_Battles { get; set; }

        [DataMember]
        public ICollection<Unit_Battle> Unit_Battles { get; set; }

        [DataMember]
        public ICollection<Battle_ByHour> Battle_ByHours { get; set; }

        public Battle()
        {
            GlobalWar = new();
            Country_Battles = new HashSet<Country_Battle>();
            Unit_Battles = new HashSet<Unit_Battle>();
            Battle_ByHours = new HashSet<Battle_ByHour>();
        }
    }
}
