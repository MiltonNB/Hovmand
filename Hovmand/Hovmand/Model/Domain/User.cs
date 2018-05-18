using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hovmand.Model.Domain
{
    public partial class User
    {
        public User()
        {
            Leads = new HashSet<Lead>();
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public ICollection<Lead> Leads { get; set; }
       
        
    }
}
