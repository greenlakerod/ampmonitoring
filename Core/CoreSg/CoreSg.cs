// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;
using Avanade.Amp.Core.Role;

namespace Avanade.Amp.Core.CoreSg
{
    public class CoreSg
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ExternalIdentity { get; set; }
        public string TenantId { get; set; }

        public bool? CanCreate { get; set; }
        public bool? CanDelete { get; set; }
        public bool? EditSiteAccess { get; set; }
        public bool? Admin { get; set; }
        public bool? Audit { get; set; }
        public bool? OpsAdmin { get; set; }

        
        public Tenant.Tenant Tenant { get; set; }

        
        public virtual List<SiteRule.SiteRule> SiteRules { get; set; }

        
        public virtual List<CoreSgRole> Roles { get; set; }
    }
}