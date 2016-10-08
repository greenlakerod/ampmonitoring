// Copyright © 2014 - Avanade Inc.

namespace Avanade.Amp.Core.Common
{
    /// <summary>
    /// Metadata about a property to aid in creating mapping within Elasticsearch.
    /// </summary>
    public class PropertyMetadata
    {
        /// <summary>
        /// Whether Elasticsearch should analyze the field for full text search.
        /// This can only be true when the property is a string.
        /// </summary>
        public bool Analyze { get; set; }

        /// <summary>
        /// The description of the property, if available.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Which Elasticsearch type the property maps to.
        /// </summary>
        public PropertyType Type { get; set; }

        /// <summary>
        /// Whether or not this property is an array of Type.
        /// </summary>
        public bool Array { get; set; }
    }
}