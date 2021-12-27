using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class ShopingCart
    {

        List<Item> cardItems = new();

        public void RemoveFromCard(Item item)
        {
            if (cardItems.Contains(item))
                cardItems.Remove(item);
        }

        public bool AddItem(Item item)
        {
            if(Stock.IsAvaliableQuantity(item))
            {
                cardItems.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetItemsCount()
        {
            return cardItems.Count;
        }
    }
}
