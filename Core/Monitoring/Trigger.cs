// Copyright © 2015 - Avanade Inc.

namespace Avanade.Amp.Core.Monitoring
{
    public class Trigger : Issuer
    {
        public string Crontab { get; set; }
        public string IssueScript { get; set; }
    }
}