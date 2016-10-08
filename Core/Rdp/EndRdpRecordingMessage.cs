namespace Avanade.Amp.Core.Rdp
{
    public class EndRdpRecordingMessage
    {
        public EndRdpRecordingMessage(string blobContainer, string blobName, string siteId)
        {
            BlobContainer = blobContainer;
            BlobName = blobName;
            SiteId = siteId;
        }

        public string BlobContainer { get; set; }
        public string BlobName { get; set; }
        public string SiteId { get; set; }
    }
}