namespace UnitTestPrivateMethods.Version2
{
    public class Item
    {
        public int Id { get; set; }

        public double Money { get; set; }

        public bool IsDiscontinued { get; set; }

        public bool IsPriceLegitForPurchase()
        {
            return this.Money < 0 || this.Money > 100;
        }

        public bool IsValidForPurchase()
        {
                if (!this.IsPriceLegitForPurchase())
                {
                    return false;
                }

                if (this.IsDiscontinued)
                {
                    return false;
                }
            return true;
        }
    }
}
