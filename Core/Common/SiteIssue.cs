using System;

namespace Avanade.Amp.Core.Common
{
    public class SiteIssue
    {
        public string Id { get; set; }

        /// <summary>
        /// The id of the site.
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// The name of the site.
        /// </summary>
        public string SiteName { get; set; }

        /// <summary>
        /// Monitored item that triggered the issue. (e.g. hostname)
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
        /// The type of target that generated the issue.
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// Type of issue.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Severity of issue.
        /// </summary>
        public int? Severity { get; set; }

        /// <summary>
        /// Time in which issue was triggered.
        /// </summary>        
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Description of the issue.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Any addtional info that can be used for post processing.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Whether the external application has consumed this issue
        /// </summary>
        public bool Consumed { get; set; }

        /// <summary>
        /// The resource on the target which is having an issue (e.g. 'c:\').
        /// This is extracted by looking in the result for the ResourceProperty defined on the trigger.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Whether the trigger will try to auto-fix issue
        /// </summary>
        public bool? AutoFix { get; set; }

        /// <summary>
        /// Name of probe that generated the result which generated this issue
        /// </summary>
        public string ProbeName { get; set; }

        /// <summary>
        /// The name of the machine that generated this issue.
        /// </summary>
        public string SiteServer { get; set; }

        /// <summary>
        /// The kibana query string to visualize this issue.
        /// </summary>
        public string Visualization { get; set; }

        /// <summary>
        /// The bundle from which the issue was raised.
        /// </summary>
        public string Bundle { get; set; }
    }
}
