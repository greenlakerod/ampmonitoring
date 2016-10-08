// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.Account
{
    public class Account
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ExternalIdentity { get; set; }
        public virtual List<SiteEntity> Sites { get; set; }
    }
}