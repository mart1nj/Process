using Process;

namespace Process.Process.Party
{
	public class SalesRelationship {

		private Role customer = Role.Customer;
        private Role provider = Role.Provider;
		private RelationshipType relationshipType = RelationshipType.Buyer_Seller;

		public SalesRelationship(){

		}

		public RelationshipType RelationshipType{
			get{
				return relationshipType;
			}
		}

		public Role Customer{
			get{
				return customer;
			}
		}
        public Role Provider{
            get{
                return provider;
            }
        }
    }
}