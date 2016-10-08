// Copyright © 2015 - Avanade Inc.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.Amp.Core.Logs;
using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.Telemetry
{
	public class RdpTelemetry
	{
		
		
		public string Id { get; set; }

		
		public string UserId { get; set; }

		
		public string AccountId { get; set; }

		
		public string SiteId { get; set; }

		
		public string HopSiteId { get; set; }

		
		public string TargetId { get; set; }

		
		public string HostServerName { get; set; }

		public RdpConnectors? ConnectionMethod { get; set; }


		public string RdpLogId { get; set; }
		

		public DateTime ConnectTime { get; set; }
		public DateTime? DisconnectTime { get; set; }
		public float? CoreClockOffset { get; set; }
		public float? SiteClockOffset { get; set; }

		public float? UserLatitude { get; set; }
		public float? UserLongitude { get; set; }

		
		public string WebsiteRegion { get; set; }

		
		public string ConnectionRegion { get; set; }


		
		public virtual RdpLog RdpLog { get; set; }
	}
}