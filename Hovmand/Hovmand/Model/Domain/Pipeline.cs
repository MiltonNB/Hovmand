using System;
using System.Collections.Generic;

namespace Hovmand
{
    public partial class Pipeline
    {
        public Pipeline()
        {
            Leads = new HashSet<Lead>();
        }

        public int PipelineId { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateLastEdit { get; set; }

        public ICollection<Lead> Leads { get; set; }
    }
}
