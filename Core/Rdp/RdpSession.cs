// Copyright © 2015 - Avanade Inc.

using System;

namespace Avanade.Amp.Core.Rdp
{
    public class RdpSession
    {
        public string Id { get; set; }
        public string ConnectionIdentity { get; set; }
        public DateTime StartTime { get; set; }
        public string UserIdentity { get; set; }
        public string CredentialIdentity { get; set; }
        public string TargetId { get; set; }
        public virtual Target.Target Target { get; set; }
    }
}