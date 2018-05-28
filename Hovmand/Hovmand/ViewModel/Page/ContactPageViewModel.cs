using System.Collections.Generic;
using System.Linq;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Data;

namespace Hovmand.ViewModel.Page
{
    public class ContactPageViewModel
    {
        private HovmanddbContext _dbContext;
        private List<Contact> _contacts;

        public ContactPageViewModel()
        {
            _dbContext = HovmanddbContext.Instance;
        }

        public List<Contact> Contacts
        {
            get { return _contacts = _dbContext.Contacts.ToList(); }
        }


    }
}