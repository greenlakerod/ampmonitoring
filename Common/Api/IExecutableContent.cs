using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Api
{
    public interface IExecutableContent
    {
        string Name { get; set; }
        string Bundle { get; set; }
        string Description { get; set; }
        ExecutableType ExecutableType { get; set; }
    }
}
