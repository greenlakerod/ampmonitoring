// Copyright © 2015 - Avanade Inc.

namespace Avanade.Amp.Core.Logs
{
    public class SecurityLog
    {
        public string Id { get; set; }

        
        public string UserIdentity { get; set; }

        public long StartTime { get; set; }

        
        public string Target { get; set; }

        public bool Allowed { get; set; }

        
        public string Method { get; set; }

        public int StatusCode { get; set; }
        public string Source { get; set; }

        
        public string RemoteIpAddress { get; set; }

        
        public string CorrelationIdentity { get; set; }

        public string Details { get; set; }
        public long? Duration { get; set; }
    }

}