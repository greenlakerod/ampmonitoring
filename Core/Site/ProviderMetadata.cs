// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.Site
{
    /// <summary>
    /// Provides information about a Provider implementation.
    /// </summary>
    public class ProviderMetadata
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public IDictionary<string, string> Parameters { get; set; }
    }
}