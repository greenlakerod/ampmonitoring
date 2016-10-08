using System;
using System.Collections.Generic;

namespace Avanade.Amp.Core.Common
{ 
    public class SiteProbe
    {
        public string Bundle { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
        public IDictionary<string, PropertyMetadata> Properties { get; set; }
        public string Crontab { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public bool Discard { get; set; }
    }
}