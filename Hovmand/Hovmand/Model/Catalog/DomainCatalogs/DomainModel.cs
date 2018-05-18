using System;
using System.Threading.Tasks;

namespace Hovmand.Model.Catalog.DomainCatalogs
{
    public class DomainModel
    {
        private ContactCatalog _contactCatalog;
        private CustomerCatalog _customerCatalog;
        private LeadCatalog _leadCatalog;
        private LocationCatalog _locationCatalog;
        private OfferCatalog _offerCatalog;
        private PipelineCatalog _pipelineCatalog;
        private ProductCatalog _productCatalog;
        private UserCatalog _userCatalog;

        private DomainModel()
        {
            _contactCatalog = new ContactCatalog();
            _customerCatalog = new CustomerCatalog();
            _leadCatalog = new LeadCatalog();
            _locationCatalog = new LocationCatalog();
            _offerCatalog = new OfferCatalog();
            _pipelineCatalog = new PipelineCatalog();
            _productCatalog = new ProductCatalog();
            _userCatalog = new UserCatalog();
        }

        public ContactCatalog Contacts { get { return _contactCatalog; } }
        public CustomerCatalog Customers { get { return _customerCatalog; } }
        public LeadCatalog Leads { get { return _leadCatalog; } }
        public LocationCatalog Locations { get { return _locationCatalog; } }
        public OfferCatalog Offers { get { return _offerCatalog; } }
        public PipelineCatalog Pipelines { get { return _pipelineCatalog; } }
        public ProductCatalog Products { get { return _productCatalog; } }
        public UserCatalog Users { get { return _userCatalog; } }

        public event Action LoadBegins;
        public event Action LoadEnds;
        public event Action SaveBegins;
        public event Action SaveEnds;

        private static DomainModel _instance;
        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }

        public static DomainModel Catalogs { get { return Instance; } }



    }
}