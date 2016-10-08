// Copyright © 2014 - Avanade Inc.

namespace Avanade.Amp.Core.Script
{
    /// <summary>
    /// Reperesents an error encountered when parsing a PowerShell script.
    /// </summary>
    public class ScriptError
    {
        /// <summary>
        /// The line containing the error
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// The line number where the error occurs.
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// The column number where the error occurs.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        public string Message { get; set; }
    }
}