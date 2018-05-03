using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Hovmand.Model.App
{
    public class Offer
    {
        private int _offerID;
        private List<string> _caseHistoryList = new List<string>();
        private List<string> _historyList = new List<string>();
        private string _caseOwner;
        private string _information;
        private float _price;
        private string _date;   

        public Offer(int offerID, List<string> caseHistoryList, string caseOwner, string information,
            List<string> historyList, float price, string date)
        {
            _offerID = offerID;
            _caseHistoryList = caseHistoryList;
            _caseOwner = caseOwner;
            _information = information;
            _historyList = historyList;
            _price = price;
            _date = date;

        }
    }
}