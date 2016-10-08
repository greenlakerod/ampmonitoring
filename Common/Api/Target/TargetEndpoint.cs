using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api.Target
{
    public class TargetEndpoint
    {
        public string Uri { get; set; }
        public string Protocol { get; set; }
        public string Host { get; set; }
        public Nullable<int> Port { get; set; }
        public string Path { get; set; }
        public string Query { get; set; }
        public string Fragment { get; set; }
    }
}
