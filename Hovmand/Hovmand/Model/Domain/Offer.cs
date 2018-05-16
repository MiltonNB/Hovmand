using System;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class Offer : DomainAppBase
    {
        public int OfferId { get; set; }
        public string Information { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int FkProductId { get; set; }
        public int FkLeadId { get; set; }

        public Lead FkLead { get; set; }
        public Product FkProduct { get; set; }
        public override void SetDefaultValues()
        {
            OfferId = NullKey;
        }
    }
}
