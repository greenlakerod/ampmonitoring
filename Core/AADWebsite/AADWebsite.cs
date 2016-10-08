// Copyright © 2015 - Avanade Inc.

namespace Avanade.Amp.Core.AADWebsite
{
    public class AADWebsite
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AzureRegion { get; set; }
        public string AADAppId { get; set; }
        public bool SiteLinkUse { get; set; }
        public string WebSpaceName { get; set; }
        public virtual AADApp.AADApp AADApp { get; set; }
    }
}