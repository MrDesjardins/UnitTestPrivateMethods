namespace UnitTestPrivateMethods.Version2
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingBasket
    {
        public List<Item> Items { get; set; }

        public ItemValidToPurchase Purchase()
        {
            var canBeBought = new ItemValidToPurchase();
            foreach (var item in Items)
            {
                bool canBuy = true;
                if(!item.IsValidForPurchase())
                {
                    canBuy = false;
                }

                if (!this.IsUnique(item.Id))
                {
                    canBuy = false;
                }

                if (this.IsShoppingBasketFull())
                {
                    canBuy = false;
                }

                if (canBeBought.HasReachMaximumAmountPerOrder())
                {
                    canBuy = false;
                }

                if (canBuy)
                {
                    canBeBought.Add(item);
                }
            }
            return canBeBought;
        }

        public bool IsUnique(int id)
        {
            return this.Items.Count(d => d.Id == id) == 1;
        }

        public bool IsShoppingBasketFull()
        {
            return this.Items.Count >= 5;
        }
    }
}