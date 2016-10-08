// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;
using Avanade.Amp.Core.Common;
using Newtonsoft.Json;

namespace Avanade.Amp.Core.Monitoring
{
    public class Probe : TrackedEntityBase
    {
        public string Id { get; set; }
        
        public string BundleId { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
        
        public string ParametersAsString
        {
            get { return JsonConvert.SerializeObject(Parameters); }
            set { Parameters = JsonConvert.DeserializeObject<IDictionary<string, object>>(value); }
        }
        public IDictionary<string, PropertyMetadata> Properties { get; set; }
        
        public string PropertiesAsString
        {
            get { return JsonConvert.SerializeObject(Properties); }
            set { Properties = JsonConvert.DeserializeObject<IDictionary<string, PropertyMetadata>>(value); }
        }
        public string Crontab { get; set; }
        public bool Discard { get; set; }
        public string Filter { get; set; }

        public virtual Bundle Bundle { get; set; }

        public override string GetId()
        {
            return Id;
        }
    }
}