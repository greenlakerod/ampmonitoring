using System;
using System.Collections.Generic;

namespace Avanade.Amp.Core.Common
{
    public class SiteTarget
    {
        /// <summary>
        /// The unique identifier for the Target.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The hostname of the target.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// What type of target this is (e.g. Server, F5, etc.)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The external identifier for the target (e.g. ServiceNow).
        /// </summary>
        public string ExternalIdentity { get; set; }

        /// <summary>
        /// The external identifier for the tenant who owns this target in 
        /// multi-tenant environments.
        /// </summary>
        public string Tenant { get; set; }

        /// <summary>
        /// The bag of additional target attributes.
        /// </summary>
        public IDictionary<string, object> Properties { get; set; }

        /// <summary>
        /// The site node that is responsible for performing monitoring.
        /// </summary>
        public string Node { get; set; }

        /// <summary>
        /// Whether the target is a member of the cluster.
        /// If so, all probes will be executed locally.
        /// </summary>
        public bool IsNode { get; set; }

        /// <summary>
        /// The last time the entity was modifed.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// The list of remote access and monitoring endpoints.
        /// </summary>
        public IEnumerable<string> Endpoints { get; set; }

        /// <summary>
        /// Should this target be monitored?
        /// </summary>
        public bool ShouldBeMonitored { get; set; }
    }
}