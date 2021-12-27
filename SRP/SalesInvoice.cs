using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class SalesInvoice
    {
        public static void CreateInvoice(ShopingCart cart  , int CustomerId)
        {


            // Method Print
            PrintingManager.Print("");

            //Method EmailService
            EmailService.Send(new object());
        }
    }
}
