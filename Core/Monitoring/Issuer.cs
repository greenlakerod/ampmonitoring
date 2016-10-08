using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Monitoring
{
    public class Issuer : TrackedEntityBase
    {
        public string Id { get; set; }
        public string BundleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? Severity { get; set; }
        public string Query { get; set; }
        public string IssueType { get; set; }
        public string Resource { get; set; }
        public string Response { get; set; }
        public string Responder { get; set; }
        public string Visualization { get; set; }
        public string ImplementationNotes { get; set; }
        public virtual Bundle Bundle { get; set; }

        public override string GetId()
        {
            return Id;
        }
    }
}
