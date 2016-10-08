// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Avanade.Amp.Core.Site
{
    public class SiteEntity
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string ExternalIdentity { get; set; }
        public string EndpointName { get; set; }
        public string EndpointSAS { get; set; }
        public string AzureRegion { get; set; }
        public string IntegrationKey { get; set; }
        public string CoreAuthKey { get; set; }
        public bool Hosted { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int? TimeZone { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool AllowManualCredential { get; set; }
        public RdpConnectors RdpConnector { get; set; }
        public virtual Account.Account Account { get; set; }
        public string ClusterId { get; set; }
        public virtual Cluster.Cluster Cluster { get; set; }
        public virtual List<Target.Target> Targets { get; set; }
        public virtual List<SiteRule.SiteRule> SiteRules { get; set; }
        public virtual List<TypeBundleMap.TypeBundleMap> TypeBundleMaps { get; set; }
        public virtual List<VaultCredential> VaultCredentials { get; set; }
        public string ShieldUser { get; set; }
        public string ShieldPassword { get; set; }
        public virtual SiteMonitoringConfig SiteMonitoringConfig { get; set; }
    }
}