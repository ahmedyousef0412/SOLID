﻿using SOLID.ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal interface IOrder : ICreaditOrder , ICacheOrder , IOnlineOrder , IInstallmentOrder
    {

        void newMethod();
       

       

    }
}
