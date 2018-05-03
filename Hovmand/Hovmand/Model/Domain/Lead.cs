namespace Hovmand.Model.Domain
{
    public class Lead
    {
        public Lead(int leadID, StatusEnum status, string information)
        {
            LeadID = leadID;
            Status = status;
            Information = information;
        }

        public int LeadID { get; set; }
        public StatusEnum Status { get; set; }
        public string Information { get; set; }
    }
}
