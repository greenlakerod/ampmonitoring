using Avanade.Amp.Core.Site;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Cluster
{
    public class Cluster
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AzureRegion { get; set; }
        public string Uri { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<SiteEntity> Sites { get; set; }
    }
}
