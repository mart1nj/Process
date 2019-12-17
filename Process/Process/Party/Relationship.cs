namespace Process.Process.Party
{
    public class Relationship
    {
        private Role consumer;
        private Role provider;
        private RelationshipType relationshipType;

        public Relationship() {
            consumer = new Role();
            provider = new Role();
        }

        public Role GetConsumer() {
            return consumer;
        }

        public void SetConsumer(string value) {
            consumer.SetName(value);
        }

        public Role GetProvider() {
            return provider;
        }

        public void SetProvider(string value) {
            provider.SetName(value);
        }

        public RelationshipType GetRelationshipType() {
            return relationshipType;
        }

        public void SetRelationshipType(RelationshipType value) {
            relationshipType = value;
        }
    }
}
