using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api.Issuer
{
    public class Percolator : Issuer
    {
        public Percolator(ExecutingFile file) : base(file) { }

        public override ExecutionData SetExecutionData()
        {
            PercolatorContent issuerContent = JsonConvert.DeserializeObject<PercolatorContent>(_executingFile.Content);
            return SetExecutionDataExtended(ExecutableType.Percolator, "percolators", Constants.URI_PERCOLATOR_EXECUTE, issuerContent);
        }
    }
}
