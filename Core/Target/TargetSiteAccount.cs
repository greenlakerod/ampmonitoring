using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.Target
{
    public class TargetSiteAccount
    {
        public Target Target { get; set; }
        public SiteEntity Site { get; set; }
        public Account.Account Account { get; set; }
    }
}
