using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;
using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core
{
    public class VaultSecret
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SiteId { get; set; }

        /// <summary>
        /// Id of the related VaultCredential.
        /// </summary>
        public string CredentialId { get; set; }

        public string Tenant { get; set; }

        
        public string Domain { get; set; }

        
        public string Username { get; set; }

        public string ExternalIdentity { get; set; }

        public virtual SiteEntity Site { get; set; }

        public virtual VaultCredential Credential { get; set; }
    }
}
