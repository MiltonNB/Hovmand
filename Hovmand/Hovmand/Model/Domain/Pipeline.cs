using System;
using System.Collections.Generic;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class Pipeline : DomainAppBase
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
        public override void SetDefaultValues()
        {
            PipelineId = NullKey;
        }
    }
}
