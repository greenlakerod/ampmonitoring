// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Script
{
    /// <summary>
    /// The result returned as part of script validation.
    /// </summary>
    public class ScriptResult
    {
        public Script Script { get; set; }

        /// <summary>
        /// The list of errors found while parsing the script.
        /// </summary>
        public IEnumerable<ScriptError> Errors { get; set; }
    }
}