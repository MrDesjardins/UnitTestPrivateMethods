using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrivateMethods
{
    using System.Collections.Generic;
    using Version1;

    [TestClass]
    public class Version1UnitTest
    {
[TestMethod]
public void TestIfIsUniqueMethodWorksWhenListHasNotUniqueItem()
{
    // Arrange
    var shoppingBasket = new ShoppingBasket();
    var item1 = new Item() {Id = 1, IsDiscontinued = false, Money = 5};
    var item2 = new Item() {Id = 2, IsDiscontinued = false, Money = 10};
    var item3 = new Item() {Id = 3, IsDiscontinued = false, Money = 20};
    var item4 = new Item() {Id = 1, IsDiscontinued = false, Money = 5};
    shoppingBasket.Items = new List<Item> {item1, item2, item3, item4};

    // Act
    var itemThatWeCanPurchase = shoppingBasket.Purchase();

    // Assert
    Assert.AreEqual(2, itemThatWeCanPurchase.Count);
}
    }
}
