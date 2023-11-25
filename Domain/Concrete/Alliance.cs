using Domain.Abstract;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    [DataContract]
    public class Alliance : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int TotalAllianceSoldier { get; set; }

        [DataMember]
        public string Flag { get; set; }

        [DataMember]
        public ICollection<Country_Alliance> Country_Alliances { get; set; }

        public Alliance()
        {
            Country_Alliances = new HashSet<Country_Alliance>();
        }
    }
}
