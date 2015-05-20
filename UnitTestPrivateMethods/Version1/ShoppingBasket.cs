namespace UnitTestPrivateMethods.Version1
{
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingBasket
    {
        public List<Item> Items { get; set; }

        public List<Item> Purchase()
        {
            var canBeBought = new List<Item>();
            foreach (var item in Items)
            {
                bool canBuy = true;
                if (item.Money < 0 || item.Money > 100)
                {
                    canBuy = false;
                }

                if (item.IsDiscontinued)
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

                if (this.HasReachMaximumAmountPerOrder(canBeBought))
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

        private bool IsUnique(int id)
        {
            return this.Items.Count(d => d.Id == id) > 1;
        }

        private bool IsShoppingBasketFull()
        {
            return this.Items.Count >= 5;
        }

        private bool HasReachMaximumAmountPerOrder(List<Item> canBeBought)
        {
            return canBeBought.Sum(d=>d.Money) > 50;
        }
    }
}