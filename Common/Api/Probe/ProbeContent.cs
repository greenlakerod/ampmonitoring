using Avanade.Amp.Core.Common;
using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Probe
{
    public class ProbeContent : IExecutableContent
    {
        public string Bundle { get; set; }
        public string Crontab { get; set; }
        public string Description { get; set; }
        public bool Discard { get; set; }
        public ExecutableType ExecutableType { get; set; }
        public string Filter { get; set; }
        public string Name { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
        public IDictionary<string, PropertyMetadata> Properties { get; set; }
        public string Provider { get; set; }

        public ProbeContent() { }
        public ProbeContent(Core.Monitoring.Probe probe)
        {
            if (probe != null)
            {
                this.Bundle = probe.Bundle.Name;
                this.Crontab = probe.Crontab;
                this.Description = probe.Description;
                this.Discard = probe.Discard;
                this.Filter = probe.Filter;
                this.Name = probe.Name;                
                this.Parameters = probe.Parameters;
                this.Properties = probe.Properties;
            }
        }
    }
}
