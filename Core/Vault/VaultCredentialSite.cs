namespace Avanade.Amp.Core
{
    public class VaultCredentialSite
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SecretId { get; set; }
        public string Tenant { get; set; }

        public string[] Tags { get; set; }

        public string[] Targets { get; set; }

        public string[] TargetTypes { get; set; }

        public string[] Roles { get; set; }
    }
}