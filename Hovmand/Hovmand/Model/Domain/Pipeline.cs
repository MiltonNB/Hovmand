using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public class Pipeline : DomainAppBase
    {
        public Pipeline(int key, int pipelineID, StatusEnum status, string information, string date, string lastEditDate)
        {
            Key = key;
            PipelineID = pipelineID;
            Status = status;
            Information = information;
            Date = date;
            LastEditDate = lastEditDate;
        }

        public int PipelineID { get; set; }

        public StatusEnum Status { get; set; }

        public string Information { get; set; }

        public string Date { get; set; }

        public string LastEditDate { get; set; }
        public override void SetDefaultValues()
        {
            Key = NullKey;
        }
    }
}