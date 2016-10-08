// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Site
{
    public class ElasticNodesStats
    {
        // ReSharper disable once InconsistentNaming
        public string cluster_name { get; set; }
        public Dictionary<string, ElasticClusterNode> nodes { get; set; }
    }
}