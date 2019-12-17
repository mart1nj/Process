using System.Collections.Generic;
using Process.Process.Party;

namespace Process.Process.Tasks {
	public abstract class Task : SalesRelationship {
        public Task(){
            Outcomes = new List<Outcome>();
		}
        public abstract void DoTask();
        public List<Outcome> Outcomes { get; set; }

    }

}