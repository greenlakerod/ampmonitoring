using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Settings
{
    public class SettingsSchema
    {
        public IEnumerable<string> FileMatch { get; set; }
        public string Url { get; set; }
    }
}
