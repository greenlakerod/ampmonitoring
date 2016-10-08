// Copyright © 2015 - Avanade, Inc.

using Avanade.Amp.Core.Account;
using Avanade.Amp.Core.Site;


namespace Avanade.Amp.Core.Target
{
    
    public class TargetSiteAccountWeb
    {
        public TargetSiteAccountWeb()
        {
        }

        public TargetSiteAccountWeb(Target target)
        {
            Target = TargetWeb.ToTargetWeb(target);
            Site = SiteEntityWeb.ToSiteEntityWeb(target.Site);
            Account = AccountWeb.ToAccountWeb(target.Site.Account);
        }

        public TargetWeb Target { get; set; }
        public SiteEntityWeb Site { get; set; }
        public AccountWeb Account { get; set; }
    }
}