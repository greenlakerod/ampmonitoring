namespace Avanade.Amp.Common.Api.Probe
{
    public class ProbeExecuteApiRequestPayloadData : IApiRequestPayloadData
    {
        public ProbeContent Probe { get; set; }
        public Target.Target Target { get; set; }
    }
}
