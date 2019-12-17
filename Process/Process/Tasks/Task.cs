using System.Collections.Generic;
using Process.Process.Party;

namespace Process.Process.Tasks {
	public abstract class Task : Relationship {
        private readonly List<Outcome> outcomes;

        public Task(){
            outcomes = new List<Outcome>();
            SetRelationshipType(RelationshipType.SalesRelationship);
		}
        public virtual void DoTask(string consumer, string provider)
        {
            SetConsumer(consumer);
            SetProvider(provider);
        }

        public List<Outcome> GetOutcomes()
        {
            return outcomes;
        }
    }

}