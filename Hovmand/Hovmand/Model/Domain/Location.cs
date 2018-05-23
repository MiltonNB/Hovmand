using System.Collections.Generic;

namespace Hovmand
{
    public partial class Location
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
    }
}
