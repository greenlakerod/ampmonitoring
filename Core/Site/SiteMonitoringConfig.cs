namespace Avanade.Amp.Core.Site
{
    public class SiteMonitoringConfig
    {
        public string Id { get; set; }
        public string ElasticsearchDataLocationPath { get; set; }
        public virtual SiteEntity SiteEntity { get; set; }
    }
}
