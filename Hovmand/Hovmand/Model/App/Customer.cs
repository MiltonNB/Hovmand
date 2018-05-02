namespace Hovmand.Model.App
{
    public class Customer
    {
        private int _customerID;
        private int _cvr;
        private string _companyName;
        private string _address;
        private int _phone;
        private string _mail;

        public Customer(int customerID, int cvr, string companyName, string address, int phone, string mail)
        {
            _customerID = customerID;
            _cvr = cvr;
            _companyName = companyName;
            _address = address;
            _phone = phone;
            _mail = mail;
        }

    }
}