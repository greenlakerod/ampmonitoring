// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;

namespace Avanade.Amp.Core.ApiDefinition
{
    public class ApiDefinition
    {       
        public string Id { get; set; }
        public string RelativePath { get; set; }
        public string Method { get; set; }
        public string Documentation { get; set; }
        public List<ApiParameter> Parameters { get; set; }
    }
}