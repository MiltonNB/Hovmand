using System.Collections.Generic;
using Data.InMemory.Interfaces;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class Contact : DomainAppBase
    {
        public Contact()
        {
            Customers = new HashSet<Customer>();
        }

        public int ContactId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        public int? Phone { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public override void SetDefaultValues()
        {
            ContactId = NullKey;
        }

    }
}
