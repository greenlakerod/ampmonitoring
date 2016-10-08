// Copyright © 2014 - Avanade Inc.

namespace Avanade.Amp.Core.Script
{
    /// <summary>
    /// Represents a parameter within a PowerShell script.
    /// </summary>
    public class ScriptParameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the parameter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The type of the parameter.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The default value of the parameter.
        /// </summary>
        public object DefaultValue { get; set; }

        /// <summary>
        /// Whether the parameter is required.
        /// </summary>
        public bool Mandatory { get; set; }

        /// <summary>
        /// The position of the parameter.
        /// </summary>
        public int? Position { get; set; }
    }
}
