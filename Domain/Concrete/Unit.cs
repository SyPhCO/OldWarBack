using Domain.Abstract;
using Domain.Body;
using System.Runtime.Serialization;

namespace Domain.Concrete
{
    [DataContract]
    public class Unit : Identity
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string? Firstname { get; set; }

        [DataMember]
        public string? Lastname { get; set; }

        [DataMember]
        public string? ChargeMusic { get; set; }

        [DataMember]
        public Rank Rank { get; set; }

        [DataMember]
        public Category Category { get; set; }

        [DataMember]
        public Country Country { get; set; }

        [DataMember]
        public Faction Faction { get; set; }

        [DataMember]
        public ICollection<Unit_Battle> Unit_Battle { get; set; }

        public Unit()
        {
            Rank = new();
            Category = new();
            Country = new();
            Faction = new();
            Unit_Battle = new HashSet<Unit_Battle>();
        }

        public Unit(UnitBody unitBody)
        {
            Unit unit = new Unit();
                unit.Name = unitBody.Name;
                unit.Description = unitBody.Description;
                unit.Firstname = unitBody.Firstname;
                unit.Lastname = unitBody.Lastname;
                unit.ChargeMusic = unitBody.ChargeMusic;
            unit.Rank.Id = unitBody.Rank;
                unit.Category.Id = unitBody.Category;
            unit.Country.Id = unitBody.Country;
            unit.Faction.Id = unitBody.Faction;
        }
    }
}
