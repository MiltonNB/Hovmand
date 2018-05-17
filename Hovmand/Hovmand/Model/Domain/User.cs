using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.InMemory.Interfaces;
using Hovmand.Model.Base;
using Hovmand.Model.Database;

namespace Hovmand.Model.Domain
{
    public partial class User : DomainAppBase, IStorable
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

        public override void SetDefaultValues()
        {
            //UserId = NullKey;
        }

        [NotMapped]
        public ICollection<Lead> Leads { get; set; }
        [NotMapped]
        public new int Key => UserId;
    }
}
