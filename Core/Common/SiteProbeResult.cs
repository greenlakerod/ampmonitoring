using System;
using System.Collections.Generic;

namespace Avanade.Amp.Core.Common
{
    /// <summary>
    /// The result of a probe execution.
    /// </summary>
    public class SiteProbeResult
    {
        /// <summary>
        /// The Id of the document. Typically this is set by Elasticsearch.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The type of probe that generated the data.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The name of the bundle, useful when the probe type is dynamic.
        /// </summary>
        public string Bundle { get; set; }

        /// <summary>
        /// The name of the provider which executed the probe.
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// The id of the site.
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// The name of the site.
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// The id of the target of the probe.
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// The name (typically the hostname) of the target.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// The external identifier for the target.
        /// </summary>
        public string TargetExternalIdentity { get; set; }

        /// <summary>
        /// The external identifier for the tenant who owns this target in 
        /// multi-tenant environments.
        /// </summary>
        public string TargetTenant { get; set; }

        /// <summary>
        /// The type of target that the data came from.
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// The time the data was collected.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// The exception encountered executing the probe
        /// </summary>
        public string[] Exceptions { get; set; }

        /// <summary>
        /// The properties collected by the probe. 
        /// </summary>   
        public IDictionary<string, object> Properties { get; set; }
    }
}
