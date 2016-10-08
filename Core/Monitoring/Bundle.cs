// Copyright © 2015 - Avanade Inc.

using Avanade.Amp.Core.Kibana;
using System.Collections.Generic;

namespace Avanade.Amp.Core.Monitoring
{
    public class Bundle : TrackedEntityBase
    {
        
        public string Id { get; set; }

        
        public string Name { get; set; }

        public string Description { get; set; }
        public string Version { get; set; }

        
        public virtual List<Bundle> Dependencies { get; set; }

        
        public virtual List<Percolator> Percolators { get; set; }

        
        public virtual List<Probe> Probes { get; set; }

        
        public virtual List<Trigger> Triggers { get; set; }

        
        public virtual List<KibanaConfig> KibanaConfigs { get; set; }

        
        public virtual List<VaultCredential> VaultCredentials { get; set; }

        public override string GetId()
        {
            return Id;
        }
    }
}