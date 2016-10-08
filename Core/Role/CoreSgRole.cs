// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Role
{
    public class CoreSgRole
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string CoreSgId { get; set; }
        public CoreSg.CoreSg CoreSg { get; set; }
        public virtual List<VaultCredential> VaultCredentials { get; set; }
    }
}