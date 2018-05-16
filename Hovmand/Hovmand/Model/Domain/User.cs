using System.Collections.Generic;
using Hovmand.Model.Base;

namespace Hovmand.Model.Domain
{
    public partial class User : DomainAppBase
    {
        public User()
        {
            Leads = new HashSet<Lead>();
        }

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Lead> Leads { get; set; }
        public override void SetDefaultValues()
        {
            UserId = NullKey;
        }
    }
}
