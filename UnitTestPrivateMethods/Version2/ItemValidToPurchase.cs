namespace UnitTestPrivateMethods.Version2
{
    using System.Collections.Generic;
    using System.Linq;

    public class ItemValidToPurchase : List<Item>
    {
        public bool HasReachMaximumAmountPerOrder()
        {
            return this.Sum(d => d.Money) > 50;
        }
    }
}