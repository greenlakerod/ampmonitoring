// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;


namespace Avanade.Amp.Core.Site
{
    
    public class SiteLinkPrefetchWeb
    {
        public SiteLinkPrefetchWeb()
        {
            SiteServers = new List<SiteServerWeb>();
            CoreWebsites = new List<AzureWebsiteWeb>();
            ElasticNodes = new List<ElasticNodeWeb>();
        }

        public HybridConnectionWeb HybridConnection { get; set; }
        public List<SiteServerWeb> SiteServers { get; set; }
        public List<ElasticNodeWeb> ElasticNodes { get; set; }
        public List<AzureWebsiteWeb> CoreWebsites { get; set; }
    }

    public class HybridConnection
    {
        public string HostName { get; set; }
        public int ListenerCount { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
    }

    public class HybridConnectionWeb
    {
        public HybridConnectionWeb(HybridConnection hc)
        {
            Name = hc.Name;
            HostName = hc.HostName;
            Port = hc.Port;
            ListenerCount = hc.ListenerCount;
        }

        public string Name { get; set; }
        public string HostName { get; set; }
        public int Port { get; set; }
        public int ListenerCount { get; set; }
    }

    
    public class SiteServerWeb
    {
        public string Name { get; set; }
        public string TenantName { get; set; }
    }

    
    public class ElasticNodeWeb
    {
        public string Name { get; set; }
        public string Host { get; set; }
    }

    
    public class AzureWebsiteWeb
    {
        public string Name { get; set; }
        public bool HybridConnectionRegistered { get; set; }
    }
}