// Copyright © 2015 - Avanade Inc.

using Avanade.Amp.Core.Monitoring;

namespace Avanade.Amp.Core.Kibana
{
    public class KibanaConfig : TrackedEntityBase
    {
        public string Id { get; set; }
        public string ElasticIdentity { get; set; }

        public string SourceJson { get; set; }

        
        public string BundleId { get; set; }


        public virtual Bundle Bundle { get; set; }

        public override string GetId()
        {
            return Id;
        }
    }
}