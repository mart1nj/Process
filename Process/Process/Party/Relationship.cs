namespace Process.Process.Party
{
    public abstract class Relationship{
        public RelationshipType RelationshipType { get; set; }
        public Role Customer { get; } = Role.Customer;
        public Role Provider { get; } = Role.Provider;
    }
}
