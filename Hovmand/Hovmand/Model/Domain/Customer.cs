using System.Collections.Generic;

namespace Hovmand.Model.Domain
{
    public partial class Customer
    {
        public Customer()
        {
            Leads = new HashSet<Lead>();
        }

        public int CustomerId { get; set; }
        public int Cvr { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public int FkContactId { get; set; }
        public int FkLocationId { get; set; }

        public Contact FkContact { get; set; }
        public Location FkLocation { get; set; }
        public ICollection<Lead> Leads { get; set; }
        
    }
}
