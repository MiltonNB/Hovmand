using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Database;
using Hovmand.ViewModel.Commands;

namespace Hovmand.ViewModel.Page
{
    public class CustomerPageViewModel
    {
        private HovmanddbContext _dbContext;
        private List<Customer> _customers;
        private CatalogBase<Customer> _customerCatalog;

        public CustomerPageViewModel()
        {
            _dbContext = HovmanddbContext.Instance;
            _customerCatalog = new CatalogBase<Customer>();
        }

        public List<Customer> Customers
        {
            get { return _dbContext.Customers.ToList(); }
        }
    }
}