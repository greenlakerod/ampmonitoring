using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Issuer
{
    public class PercolatorContent : IssuerContent
    {
        public bool MatchAll { get; set; }

        public PercolatorContent() { }
        public PercolatorContent(Core.Monitoring.Issuer issuer) : base(issuer)
        {
            this.MatchAll = ((Core.Monitoring.Percolator)issuer).MatchAll;
        }

        public override Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> dictionary = base.ToDictionary();
            dictionary.Add("MatchAll", this.MatchAll);

            return dictionary;
        }

        public override void FromDictionary(Dictionary<string, object> dictionary)
        {
            base.FromDictionary(dictionary);
            this.MatchAll = (bool)dictionary["MatchAll"];
        }
    }
}
