using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Probe
{
    public class ProbeQueryApiRequestPayloadData : IApiRequestPayloadData
    {
        public IDictionary<string, object> Parameters { get; set; }
        //public IProbeParameters Parameters { get; set; }

        public Target.Target Target { get; set; }
    }
}
