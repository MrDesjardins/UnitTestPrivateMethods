using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrivateMethods
{
    using System.Collections.Generic;
    using Version2;

    [TestClass]
    public class Version2UnitTest
    {

private ShoppingBasket GetShoppingBasket()
{
    var shoppingBasket = new ShoppingBasket();
    var item1 = new Item() {Id = 1, IsDiscontinued = false, Money = 5};
    var item2 = new Item() {Id = 2, IsDiscontinued = false, Money = 10};
    var item3 = new Item() {Id = 3, IsDiscontinued = false, Money = 20};
    var item4 = new Item() {Id = 1, IsDiscontinued = false, Money = 5};
    shoppingBasket.Items = new List<Item> {item1, item2, item3, item4};
    return shoppingBasket;
}

[TestMethod]
public void TestIfIsUniqueMethodWorksWhenListHasNotUniqueItem()
{
    // Arrange
            var shoppingBasket = this.GetShoppingBasket();

    // Act
    var isUnique = shoppingBasket.IsUnique(1);

    // Assert
    Assert.IsFalse(isUnique);
}

[TestMethod]
public void TestIfIsUniqueMethodWorksWhenListHasUniqueItem()
{
    // Arrange
    var shoppingBasket = this.GetShoppingBasket();

    // Act
    var isUnique = shoppingBasket.IsUnique(2);

    // Assert
    Assert.IsTrue(isUnique);
}

    }
}
