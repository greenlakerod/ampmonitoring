// Copyright © 2015 - Avanade Inc.

using Newtonsoft.Json;

namespace Avanade.Amp.Core.Common
{
    public class SiteSchedule
    {
        [JsonIgnore]
        public string Name => $"{Bundle}({TargetId})";

        public string Bundle { get; set; }
        public string TargetId { get; set; }
    }
}