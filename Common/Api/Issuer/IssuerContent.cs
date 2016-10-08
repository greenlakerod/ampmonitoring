using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Issuer
{
    public abstract class IssuerContent : IExecutableContent, IApiRequestPayloadData
    {
        public string Bundle { get; set; }
        public string Description { get; set; }
        public ExecutableType ExecutableType { get; set; }
        public string IssueType { get; set; }
        public string Name { get; set; }
        public string Query { get; set; }
        public string Resource { get; set; }
        public int Severity { get; set; }
        public string Type { get; set; }

        public IssuerContent() { }
        public IssuerContent(Core.Monitoring.Issuer issuer)
        {
            this.Bundle = issuer.Bundle.Name;
            this.Description = issuer.Description;
            this.IssueType = issuer.IssueType;
            this.Name = issuer.Name;
            this.Query = issuer.Query;

            if (issuer.Severity.HasValue)
            {
                this.Severity = issuer.Severity.Value;
            }           
        }

        public virtual Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Bundle", this.Bundle);
            dictionary.Add("Description", this.Description);
            dictionary.Add("IssueType", this.IssueType);
            dictionary.Add("Name", this.Name);
            dictionary.Add("Query", this.Query);
            dictionary.Add("Resource", this.Resource);
            dictionary.Add("Severity", this.Severity);

            return dictionary;
        }

        public virtual void FromDictionary(Dictionary<string, object> dictionary)
        {
            this.Bundle = (string)dictionary["Bundle"];
            this.Description = (string)dictionary["Description"];
            this.IssueType = (string)dictionary["IssueType"];
            this.Name = (string)dictionary["Name"];
            this.Query = (string)dictionary["Query"];
            this.Resource = (string)dictionary["Resource"];
            this.Severity = (int)dictionary["Severity"];
        }
    }
}
