// Copyright © 2014 - Avanade Inc.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.AADApp
{
    public class AADApp
    {
        public string Id { get; set; }
        public AADAppName Name { get; set; }       
        public string ClientId { get; set; }       
        public string AppIdUri { get; set; }       
        public string DnsName { get; set; }       
        public string TrafficManagerUrl { get; set; }     
        public virtual List<AADWebsite.AADWebsite> AADWebsites { get; set; }

        public Uri GetAppUrl()
        {
            return new Uri(DnsName.StartsWith("http") ? DnsName : "https://" + DnsName);
        }
    }

    public interface IAADAppStoreExt
    {
        Task<AADApp> GetAADAppByNameAsync(AADAppName appName);
        Task<AADApp> GetCoreApiAppAsync();
        AADApp GetAADAppByName(AADAppName appName);
        AADApp GetCoreApiApp();
    }
}