// Copyright © 2015 - Avanade Inc.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Logs
{
    public class ScriptExecutionLog
    {
        public string Id { get; set; }

        public string UserIdentity { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public DateTime? EndTimeUtc { get; set; }
        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string Data { get; set; }
        public string RemoteIpAddress { get; set; }
        public string ConnectionId { get; set; }
    }
}