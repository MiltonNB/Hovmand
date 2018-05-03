using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Hovmand.Model.App
{
    public class Offer
    {
        public Offer(int offerID,string caseOwner, string information, float price, string date)
        {
            OfferID = offerID;
            CaseHistoryList = new List<string>();
            HistoryList = new List<string>();
            CaseOwner = caseOwner;
            Information = information;
            Price = price;
            Date = date;
        }

        public int OfferID { get; set; }
        public List<string> CaseHistoryList { get; set; }
        public List<string> HistoryList { get; set; }
        public string CaseOwner { get; set; }
        public string Information { get; set; }
        public float Price { get; set; }
        public string Date { get; set; }
    }
}