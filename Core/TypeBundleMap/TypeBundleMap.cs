// Copyright © 2015 - Avanade, Inc.


using Avanade.Amp.Core.Monitoring;
using Avanade.Amp.Core.Site;


namespace Avanade.Amp.Core.TypeBundleMap
{
    public class TypeBundleMap
    {     
        public string Id { get; set; }
        public string Type { get; set; }
        public string BundleId { get; set; }
        public string SiteId { get; set; }
        public virtual SiteEntity Site { get; set; }
        public virtual Bundle Bundle { get; set; }
    }
}