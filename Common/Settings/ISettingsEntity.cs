using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Settings
{
    public interface ISettingsEntity
    {
        string Id { get; set; }
        string Name { get; set; }
    }
}
