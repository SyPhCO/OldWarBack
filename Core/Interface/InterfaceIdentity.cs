namespace Domain.Interface
{
    public interface InterfaceIdentity
    {
        public long Id { get; set; }

        public string UserCreation { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string UserModification { get; set; }
    }
}
