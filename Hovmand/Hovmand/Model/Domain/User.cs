using System.Collections.Generic;

namespace Hovmand
{
    public partial class User
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
    }
}
