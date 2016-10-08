using System.Collections.Generic;
using System.Linq;

namespace Avanade.Amp.Common.Api.Target
{
    //todo: generate this in Core
    public class TargetProperties
    {
        public string TargetType { get; set; }
        public IEnumerable<string> ConnectsTo { get; set; }
        public string Farm { get; set; }
        public string Fqdn { get; set; }
        public IEnumerable<string> Guests { get; set; }
        public string InstanceName { get; set; }
        public IEnumerable<string> IPAddress { get; set; }
        public string IspConnection { get; set; }
        public IEnumerable<string> MajorVersion { get; set; }
        public string Manufacturer { get; set; }
        public IEnumerable<string> Members { get; set; }
        public IEnumerable<string> MinorVersion { get; set; }
        public string Model { get; set; }
        public IEnumerable<string> Partitions { get; set; }
        public string Pool { get; set; }
        public IEnumerable<string> Roles { get; set; } 
        public IEnumerable<string> Runs { get; set; }
        public string RunsOn { get; set; }
        public string RunsOnType { get; set; }
        public IEnumerable<string> RunsTypes { get; set; }
        public string TcpPort { get; set; }
        public string Trunk { get; set; }
        public IEnumerable<string> Version { get; set; }

        public IDictionary<string, object> ToDictionary()
        {
            return this.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public).ToDictionary(p => p.Name, p => p.GetValue(this));
        }
    }
}
