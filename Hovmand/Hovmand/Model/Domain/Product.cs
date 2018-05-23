using System.Collections.Generic;

namespace Hovmand
{
    public partial class Product
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
    }
}
