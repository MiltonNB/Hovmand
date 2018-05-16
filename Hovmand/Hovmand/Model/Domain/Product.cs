using System.Collections.Generic;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class Product : DomainAppBase
    {
        public Product()
        {
            Offers = new HashSet<Offer>();
        }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }

        public ICollection<Offer> Offers { get; set; }
        public override void SetDefaultValues()
        {
            ProductId = NullKey;
        }
    }
}
