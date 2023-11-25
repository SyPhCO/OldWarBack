using Domain.Abstract;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    [DataContract]
    public class Faction : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Flag { get; set; }

        [DataMember]
        public string Chief { get; set; }

        [DataMember]
        public ICollection<Faction_ByHour> Faction_ByHours { get; set; }

        public Faction()
        {
            Faction_ByHours = new HashSet<Faction_ByHour>();
        }
    }
}
