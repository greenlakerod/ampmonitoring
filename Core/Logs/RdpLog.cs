// Copyright © 2015 - Avanade Inc.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Logs
{
    public class RdpLog
    {
        public string Id { get; set; }
        
        public string UserIdentity { get; set; }

        public DateTime StartTimeUtc { get; set; }

        //ticks
        public DateTime? EndTimeUtc { get; set; }

        
        public string AccountExternalIdentity { get; set; }

        
        public string AccountIdentity { get; set; }

        
        public string AccountName { get; set; }

        
        public string SiteExternalIdentity { get; set; }

        
        public string SiteIdentity { get; set; }

        
        public string SiteName { get; set; }

        
        public string HopSiteIdentity { get; set; }

        
        public string HopSiteName { get; set; }

        
        public string TargetIdentity { get; set; }

        
        public string TargetName { get; set; }

        
        public string ConnectionIdentity { get; set; }

        public long BytesSent { get; set; }
        public long BytesReceived { get; set; }
    }

}