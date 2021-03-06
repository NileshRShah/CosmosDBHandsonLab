﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeFeedProcessor
{
    public class CosmosSettings
    {
        public string DbUrl { get; set; }
        public string DbName { get; set; }
        public string CollectionName { get; set; }
        public string LeaseCollectionName { get; set; }
        public string AuthorizationKey { get; set; }
        public int OfferThroughput { get; set; }
        public int MaxConnectionLimit { get; set; }
    }
}

