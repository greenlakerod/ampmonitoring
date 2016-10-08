using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Avanade.Amp.Core.Site;


namespace Avanade.Amp.Core.Rdp
{
    public class RdpEncodingLog
    {
        public string Id { get; set; }
        public string SiteId { get; set; }
        public string ConnectionId { get; set; }
        public double Progress { get; set; }
        public DateTime? LatestProgressUpdate { get; set; }
        public bool RequestedCancel { get; set; }
        public string Status { get; set; }
        public string Format { get; set; }
        public virtual SiteEntity Site { get; set; }
    }
}
