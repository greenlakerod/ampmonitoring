using System.Collections.Generic;
using Avanade.Amp.Core.Common;

namespace Avanade.Amp.Core.Hosted.Trigger
{
    public class TriggerTestResponse
    {
        public string RawQueryResponse { get; set; }

        public IEnumerable<SiteProbeResult> Results { get; set; }
    }
}