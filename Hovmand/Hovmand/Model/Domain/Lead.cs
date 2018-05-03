using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hovmand.Model.App
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
