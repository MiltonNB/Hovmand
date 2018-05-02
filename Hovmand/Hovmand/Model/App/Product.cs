namespace Hovmand.Model.App
{
    public class Product
    {
        private int _productID;
        private string _title;
        private string _information;
        private float _price;

        public Product(int productID, string title, string information, float price)
        {
            _productID = productID;
            _title = title;
            _information = information;
            _price = price;
        }

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Information
        {
            get { return _information; }
            set { _information = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}