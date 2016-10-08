// Copyright © 2015 - Avanade Inc.

using System;
using System.Collections.Generic;

namespace Avanade.Amp.Core.Directory
{
    public class DirectoryUser
    {
        public string UserPrincipalName { get; set; }
        public string DisplayName { get; set; }
        public string ThumbnailPhoto { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}