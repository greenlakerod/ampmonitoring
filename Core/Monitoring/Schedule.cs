using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.Monitoring
{
    public class Schedule
    {
        public string Id { get; set; }
        public string BundleId { get; set; }
        public virtual Bundle Bundle { get; set; }
        public string TargetId { get; set; }
        public virtual Target.Target Target { get; set; }
        public string SiteId { get; set; }
        public virtual SiteEntity Site { get; set; }
    }
}
