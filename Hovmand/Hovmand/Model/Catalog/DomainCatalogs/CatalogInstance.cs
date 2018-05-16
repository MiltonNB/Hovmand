namespace Hovmand.Model.Catalog.DomainCatalogs
{
    public class CatalogInstance
    {
        private ContactCatalog _contactCatalog;
        private CustomerCatalog _customerCatalog;
        private LeadCatalog _leadCatalog;
        private LocationCatalog _locationCatalog;
        private OfferCatalog _offerCatalog;
        private PipelineCatalog _pipelineCatalog;
        private ProductCatalog _productCatalog;
        private UserCatalog _userCatalog;

        private CatalogInstance()
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
    }
}