using System;
using Hovmand.Model.App;
using Hovmand.Model.Catalog.Base;
using Hovmand;
using Hovmand.Model.App;
using Hovmand.Model.Catalog.Base;
using System;
using Windows.UI.Xaml.Controls;
using Hovmand.ViewModel.App;


namespace HovmandUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        #region Catalog - Adding of objects

        [TestCategory("Catalog - Add")]
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

        [TestCategory("Catalog - Add")]
        [TestMethod]
        public void AddToCatalogIncompleteObject()
        {
            var product = new Product()
            {
            };
            var cProd = new CatalogBase<Product>();
            cProd.Create(product);
        }

        [TestCategory("Catalog - Read")]
        [TestMethod]
        public void ReadFromCatalogKeyExists()
        {
            var catalogUser = new CatalogBase<User>();
            catalogUser.Read(1);
        }

        [TestCategory("Catalog - Read")]
        [TestMethod]
        public void ReadFromCatalogKeyDoesNotExist()
        {
            var catalogUser = new CatalogBase<User>();
            catalogUser.Read(100);
        }

        [TestCategory("Catalog - Update")]
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

        [TestCategory("Catalog - Update")]
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

        [TestCategory("Catalog - Delete")]
        [TestMethod]
        public void DeleteFromCatalogKeyExists()
        {
            var catalogProduct = new CatalogBase<Product>();
            catalogProduct.Delete(2);
        }

        [TestCategory("Catalog - Delete")]
        [TestMethod]
        public void DeleteFromCatalogKeyDoesNotExist()
        {
            var catalogProduct = new CatalogBase<Product>();
            catalogProduct.Delete(200);
        }

        #endregion

        #region PasswordHash

        [TestCategory("Password hashing")]
        [TestMethod]
        public void HashStringAlphanumeric()
        {
            var pwhash = new PasswordHash();
            pwhash.HashString("Unit tests are cool 123");
        }

        [TestCategory("Password hashing")]
        [TestMethod]
        public void HashStringSymbols()
        {
            var pwhash = new PasswordHash();
            pwhash.HashString("&)#¤#");
        }

        [TestCategory("Password hashing")]
        [TestMethod]
        public void HashStringEmpty()
        {
            var pwhash = new PasswordHash();
            pwhash.HashString(String.Empty);
        }

        [TestCategory("Password hashing")]
        [TestMethod]
        public void ComparePasswordsMatching()
        {
            var pwhash = new PasswordHash();
            pwhash.MatchString("i love unit tests", "cd7f7061fc5e921a5ed22ca5ea37beea8d752da0");
        }

        [TestCategory("Password hashing")]
        [TestMethod]
        public void ComparePasswordsNotMatching()
        {
            var pwhash = new PasswordHash();
            pwhash.MatchString("i love unit tests!!", "cd7f7061fc5e921a5ed22ca5ea37beea8d752da0");
        }

        [TestCategory("Password hashing")]
        [TestMethod]
        public void ComparePasswordsEmpty()
        {
            var pwhash = new PasswordHash();
            pwhash.MatchString(String.Empty, String.Empty);
        }

        #endregion
    }
}
