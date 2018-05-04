using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public class Lead : DomainAppBase
    {
        public Lead(int key, int leadID, StatusEnum status, string information)
        {
            Key = key;
            LeadID = leadID;
            Status = status;
            Information = information;
        }

        public Lead() : base()
        {

        }

        public int LeadID { get; set; }
        public StatusEnum Status { get; set; }
        public string Information { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
        }
    }
}
