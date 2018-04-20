using Cosmetics.Cart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cosmetics.UnitTests.ShoppingCartTest
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void InitializeNewListOfProductsWhenCategoryIsCreated()
        {
            // Arrange, Act

            var category = new ShoppingCart();

            // Assert
            Assert.IsNotNull(category.ProductList);
        }
    }
}