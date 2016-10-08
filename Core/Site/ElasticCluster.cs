// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Site
{
    public class ElasticCluster
    {
        // ReSharper disable once InconsistentNaming
        public string cluster_name { get; set; }
        public string status { get; set; }
        // ReSharper disable once InconsistentNaming
        public Dictionary<string, ElasticClusterNode> nodes { get; set; }
    }
}