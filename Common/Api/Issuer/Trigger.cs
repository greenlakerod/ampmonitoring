using Newtonsoft.Json;

namespace Avanade.Amp.Common.Api.Issuer
{
    public class Trigger : Issuer
    {
        public Trigger(ExecutingFile file) : base(file) { }

        public override ExecutionData SetExecutionData()
        {
            TriggerContent issuerContent = JsonConvert.DeserializeObject<TriggerContent>(_executingFile.Content);
            return SetExecutionDataExtended(ExecutableType.Trigger, "triggers", Constants.URI_TRIGGER_EXECUTE, issuerContent);
        }
    }
}
