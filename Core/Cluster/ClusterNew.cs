namespace Avanade.Amp.Core.Cluster
{
    public class ClusterNew
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AzureRegion { get; set; }
        public string Uri { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Cluster ToCluster()
        {
            return new Cluster
            {
                Id = Id,
                Name = Name,
                AzureRegion = AzureRegion,
                Uri = Uri,
                Username = Username,
                Password = Password
            };
        }
    }
}