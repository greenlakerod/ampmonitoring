using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Issuer
{
    public class TriggerContent : IssuerContent
    {
        public string Crontab { get; set; }
        public string IssueScript { get; set; }

        public TriggerContent() { }
        public TriggerContent(Core.Monitoring.Issuer issuer) : base(issuer)
        {
            this.Crontab = ((Core.Monitoring.Trigger)issuer).Crontab;
            this.IssueScript = ((Core.Monitoring.Trigger)issuer).IssueScript;
        }

        public override Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> dictionary = base.ToDictionary();
            dictionary.Add("Crontab", this.Crontab);
            dictionary.Add("IssueScript", this.IssueScript);

            return dictionary;
        }

        public override void FromDictionary(Dictionary<string, object> dictionary)
        {
            base.FromDictionary(dictionary);
            this.Crontab = (string)dictionary["Crontab"];
            this.IssueScript = (string)dictionary["IssueScript"];
        }
    }
}
