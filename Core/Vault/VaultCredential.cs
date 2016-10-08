using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.Amp.Core.Monitoring;
using Avanade.Amp.Core.Role;
using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core
{
    public class VaultCredential
    {
        /// <summary>
        /// Id of the credential
        /// </summary>
        
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Tenant { get; set; }
        public string SiteId { get; set; }
        public string[] TargetTypes { get; set; }

        
        public string TargetTypesAsString
        {
            get
            {
                if (TargetTypes != null)
                {
                    return string.Join(",", TargetTypes);
                }
                return null;
            }
            set {
                TargetTypes = value != null ? value.Split(',') : new string[] {};
            }
        }

        
        public virtual VaultSecret VaultSecret { get; set; }

        public virtual SiteEntity Site { get; set; }

        
        public virtual List<CoreSgRole> Roles { get; set; }

        
        public virtual List<Target.Target> Targets { get; set; }

        
        public virtual List<Bundle> Bundles { get; set; }
    }
}
