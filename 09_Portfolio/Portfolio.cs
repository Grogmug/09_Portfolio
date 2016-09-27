using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        List<IAsset> items;

        public Portfolio ()
        {
            items = new List<IAsset>();
        }
        public Portfolio(List<IAsset> items)
        {
            this.items = items;
        }

        public double GetTotalValue()
        {
            double fullValue = 0;
            foreach (IAsset item in items)
            {
                fullValue += item.GetValue();
            }
            return fullValue;
        }

        public void AddAsset(IAsset listId)
        {
            items.Add(listId);
        }
    }
}