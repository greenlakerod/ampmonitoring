using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common
{
    public class Constants
    {
        public const string URI_TARGETS_FILTER_BY_SITE = "targets/filter?siteId={0}";
        public const string URI_SITES_PROXY = "sites/{0}/proxy";
        public const string URI_SITES_TEST_RENDER_ISSUES = "sites/{0}/test/render-issues";
        public const string URI_PROBE_EXECUTE = "monitoring/api/v3/provider/execute?provider={0}&bundle={1}";
        public const string URI_PROBE_QUERY = "monitoring/api/v3/provider/query?provider={0}&bundle={1}";
        public const string URI_PERCOLATOR_EXECUTE = "monitoring/api/v3/percolator/test";
        public const string URI_TRIGGER_EXECUTE = "monitoring/api/v3/trigger/testwithraw";
    }
}
