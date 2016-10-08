// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Subscription
{
    public class Subscription
    {
        public string Id { get; set; }
        public string ExternalIdentity { get; set; }
        public string TenantId { get; set; }
        public virtual Tenant.Tenant Tenant { get; set; }
    }
}