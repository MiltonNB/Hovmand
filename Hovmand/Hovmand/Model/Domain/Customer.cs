using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public class Customer : DomainAppBase
    {
        public Customer(int key, int customerID, int cvr, string companyName, string address, int phone, string mail)
        {
            Key = key;
            CustomerID = customerID;
            CVR = cvr;
            CompanyName = companyName;
            Address = address;
            Phone = phone;
            Mail = mail;
        }

        public Customer() : base()
        {
            
        }

        public int CustomerID { get; set; }

        public int CVR { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Mail { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
        }
    }
}