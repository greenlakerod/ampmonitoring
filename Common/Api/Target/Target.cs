using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avanade.Amp.Core.Target;
using Avanade.Amp.Common.Settings;

namespace Avanade.Amp.Common.Api.Target
{
    public class Target : Avanade.Amp.Core.Target.Target, ISettingsEntity
    {
        public IEnumerable<TargetEndpoint> TargetEndpoints { get; set; }
    }
}
