// Copyright © 2014 - Avanade Inc.

using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.SiteRule
{
    public class SiteRule
    {
        public string Id { get; set; }
        public bool? Allowed { get; set; }
        public bool? AuditRead { get; set; }
        public bool? Admin { get; set; }
        public string CoreSgId { get; set; }
        public string SiteId { get; set; }
        public virtual CoreSg.CoreSg CoreSg { get; set; }
        public virtual SiteEntity Site { get; set; }
    }
}
