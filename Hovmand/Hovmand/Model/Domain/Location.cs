using System.Collections.Generic;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class Location : DomainAppBase
    {
        public Location()
        {
            Customers = new HashSet<Customer>();
        }

        public int LocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Areacode { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public override void SetDefaultValues()
        {
            LocationId = NullKey;
        }
    }
}
