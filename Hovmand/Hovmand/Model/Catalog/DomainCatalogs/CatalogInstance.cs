﻿using System;
using System.Threading.Tasks;

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

        private static CatalogInstance _instance;
        public static CatalogInstance Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new CatalogInstance());
                return _instance;
            }
        }

        public static CatalogInstance Catalogs { get { return Instance; } }

        public async Task LoadAsync()
        {
            LoadBegins?.Invoke();

            await _contactCatalog.LoadAsync();
            await _customerCatalog.LoadAsync();
            await _leadCatalog.LoadAsync();
            await _locationCatalog.LoadAsync();
            await _offerCatalog.LoadAsync();
            await _pipelineCatalog.LoadAsync();
            await _productCatalog.LoadAsync();
            await _userCatalog.LoadAsync();

            LoadEnds?.Invoke();
        }

        public async Task SaveAsync()
        {
            SaveBegins?.Invoke();

            await _contactCatalog.SaveAsync();
            await _customerCatalog.SaveAsync();
            await _leadCatalog.SaveAsync();
            await _locationCatalog.SaveAsync();
            await _offerCatalog.SaveAsync();
            await _pipelineCatalog.SaveAsync();
            await _productCatalog.SaveAsync();
            await _userCatalog.SaveAsync();

            SaveEnds?.Invoke();
        }



    }
}