// Copyright © 2016 - Avanade Inc.

namespace Avanade.Amp.Core.Package
{
    /// <summary>
    /// A generic object to represent software packages.
    /// </summary>
    public class Package
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string DisplayName { get; set; }
        public string Extension { get; set; }
    }
}