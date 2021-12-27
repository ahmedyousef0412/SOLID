using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class Order : IOrder
    {
        public void newMethod()
        {
            throw new NotImplementedException();
        }

        public void ProcessCacheInvoice()
        {
            throw new NotImplementedException();
        }

        public void ProcessCrditInvoice()
        {
            throw new NotImplementedException();
        }

        public void ProcessInstallment()
        {
            throw new NotImplementedException();
        }

        public void ProcessOnlinePaymentInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
