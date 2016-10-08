// Copyright © 2015 - Avanade, Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Hosted.Trigger
{
    /// <summary>
    /// Defines the object type result of the ConditionScript.
    /// </summary>
    public class IssueScriptResult
    {
        /// <summary>
        /// Id of target of which the condition triggered on.
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// Additional information about the issue.
        /// </summary>
        public Dictionary<string, object> Properties { get; set; }
    }
}