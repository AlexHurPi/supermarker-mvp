﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IMainView
    {
        event EventHandler ShowPayModeView;
        //event EventHandler ShowMainView;
        event EventHandler ShowProductView;
        event EventHandler ShowCustomerView;

    }
}