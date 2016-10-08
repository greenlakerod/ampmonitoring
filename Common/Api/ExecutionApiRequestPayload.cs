using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api
{
    public class ExecutionApiRequestPayload
    {
        public int Method { get; set; }
        public string Uri { get; set; }
        public IApiRequestPayloadData Data { get; set; }
    }
}
