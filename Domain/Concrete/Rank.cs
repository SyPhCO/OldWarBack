using Domain.Abstract;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    [DataContract]
    public class Rank : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string PictureRank { get; set; }
    }
}
