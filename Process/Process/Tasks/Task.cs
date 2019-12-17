using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Process.Process.Party;

namespace Process.Process.Tasks {
	public abstract class Task : SalesRelationship {

		private List<Outcome> outcomes;

		public Task(){
            outcomes = new List<Outcome>();
		}

        public abstract void DoTask();

		public List<Outcome> Outcomes{
			get{
				return outcomes;
			}
			set{
                outcomes = value;
			}
		}

	}

}