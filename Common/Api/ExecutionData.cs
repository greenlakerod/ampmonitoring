using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api
{
    public class ExecutionData
    {
        public string Resource { get; set; }
        public object Payload { get; private set; }

        public void SetPayload(string payload)
        {
            this.Payload = payload;
        }

        public void SetPayload(ExecutionApiRequestPayload payload)
        {
            this.Payload = payload;
        }
    }
}
