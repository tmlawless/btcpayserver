﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBitcoin;

namespace BTCPayServer
{
    public class BTCPayNetwork
    {
        public Network NBitcoinNetwork { get; set; }
        public string CryptoCode { get; internal set; }
        public string BlockExplorerLink { get; internal set; }
        public string UriScheme { get; internal set; }
    }
}
