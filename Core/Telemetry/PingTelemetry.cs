// Copyright © 2016 - Avanade Inc.

namespace Avanade.Amp.Core.Telemetry
{
	public class PingTelemetry
	{
		public string Id { get; set; }
		public string RdpTelemetryId { get; set; }
		public int BatchNumber { get; set; }
		public int NumberOfPings { get; set; }
		public float AverageRoundtrip { get; set; }
		public float MaxRoundtrip { get; set; }
		public float MinRoundtrip { get; set; }
		public string Data { get; set; }
		public virtual RdpTelemetry RdpTelemetry { get; set; }
	}
}