using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hovmand;
using Hovmand.Annotations;
using Hovmand.Model.Catalog.Base;
using Hovmand.Model.Database;

namespace HovmandUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region DB unit tests

        [TestMethod]
        public void AddToCatalogCompleteObject()
        {
            var product = new Product()
            {
                Information = "",
                InStock = 1,
                Price = 2.0,
                Title = "",
            };
            var cProd = new CatalogBase<Product>();
            cProd.Create(product);
        }

        [TestMethod]
        public void AddToCatalogIncompleteObject()
        {
            var product = new Product()
            {

            };
            var cProd = new CatalogBase<Product>();
            cProd.Create(product);
        }

        [TestMethod]
        public void ReadFromCatalogKeyExists()
        {
            var catalogUser = new CatalogBase<User>();
            catalogUser.Read(1);
        }

        [TestMethod]
        public void ReadFromCatalogKeyDoesNotExist()
        {
            var catalogUser = new CatalogBase<User>();
            catalogUser.Read(100);
        }

        [TestMethod]
        public void UpdateCatalogCompleteObject()
        {
            var catalogProduct = new CatalogBase<Product>();
            var product = new Product()
            {
                Information = "",
                InStock = 0,
                Price = 0.0,
                Title = ""
            };
            catalogProduct.Update(product);
        }

        [TestMethod]
        public void UpdateCatalogIncompleteObject()
        {
            var catalogProduct = new CatalogBase<Product>();
            var product = new Product()
            {
                Information = "",
                InStock = 0,
                Price = 0.0,
                Title = ""
            };
            catalogProduct.Update(product);
        }

        [TestMethod]
        public void DeleteFromCatalogKeyExists()
        {
            var catalogProduct = new CatalogBase<Product>();
            catalogProduct.Delete(2);
        }

        [TestMethod]
        public void DeleteFromCatalogKeyDoesNotExist()
        {
            var catalogProduct = new CatalogBase<Product>();
            catalogProduct.Delete(200);
        }

        #endregion
    }
}
