﻿using SyncRestMOXA.Core.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncRestMOXA.Core.Abstractions
{
    public interface IRelayCategory 
        : IGetCategory<RelayCollection>, IAsyncGetCategory<RelayCollection>, IPutCategory<RelayCollection>, IAsyncPutCategory<RelayCollection>, IObservableCategory<RelayCollection>
    {

    }
}
