using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hovmand.Model.Domain
{
    public partial class Contact
    {
        public Contact()
        {
            Customers = new HashSet<Customer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        public int Phone { get; set; }

        public ICollection<Customer> Customers { get; set; }
        

    }
}
