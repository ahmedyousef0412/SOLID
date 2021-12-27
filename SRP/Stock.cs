using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class Stock
    {
        public static List<Item> items = new()
        {
            new Item{Code ="20" , Price =2500 , Quantity=30 },
            new Item{Code ="21" , Price =3000 , Quantity=35 },
            new Item{Code ="22" , Price =3500 , Quantity=40 },

        };

        public static bool IsAvaliableQuantity(Item item)
        {
            if (item.Quantity < items.Where(q => q.Code == item.Code).FirstOrDefault().Quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
    }
   
}
