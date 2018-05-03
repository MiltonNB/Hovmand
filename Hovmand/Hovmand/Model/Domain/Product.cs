using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public class Product : DomainAppBase
    {
        public Product(int key, int productID, string title, string information, float price)
        {
            Key = key;
            ProductID = productID;
            Title = title;
            Information = information;
            Price = price;
        }

        public int ProductID { get; set; }

        public string Title { get; set; }

        public string Information { get; set; }

        public float Price { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
        }
    }
}