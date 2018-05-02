namespace Hovmand.Model.App
{
    public class Product
    {
        public Product(int productID, string title, string information, float price)
        {
            ProductID = productID;
            Title = title;
            Information = information;
            Price = price;
        }

        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public float Price { get; set; }
    }
}