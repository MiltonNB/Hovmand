﻿namespace Hovmand.Model.App
{
    public class Customer
    {
        private int _customerID;
        

        public Customer(int customerID, int cvr, string companyName, string address, int phone, string mail)
        {
            _customerID = customerID;
            CVR = cvr;
            CompanyName = companyName;
            Address = address;
            Phone = phone;
            Mail = mail;
        }

        public int CustomerID { get; set; }

        public int CVR { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Mail { get; set; }



    }
}