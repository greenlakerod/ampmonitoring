using System.Collections.Generic;

namespace Avanade.Amp.Common.Api.Issuer
{
    public abstract class Issuer : Executable, IExecutableContent
    {
        public string Bundle { get; set; }
        public string Description { get; set; }
        public ExecutableType ExecutableType { get; set; }
        public string Name { get; set; }

        public Issuer(ExecutingFile file) : base(file) { }

        public override abstract ExecutionData SetExecutionData();

        protected ExecutionData SetExecutionDataExtended(ExecutableType entityType, string entityTypes, string payloadUri, IssuerContent issuerContent)
        {
            ExecutionData executionData = new ExecutionData();
            executionData.Resource = string.Format(Constants.URI_SITES_PROXY, Settings.Settings.Site.Id);
            //IssuerContent issuerContent = JsonConvert.DeserializeObject<IssuerContent>(_executingFile.Content);

            Dictionary<string, object> content = issuerContent.ToDictionary();
            AddExternalFileContent(content);

            issuerContent.FromDictionary(content);
            issuerContent.ExecutableType = entityType;

            //add other required properties
            if (string.IsNullOrWhiteSpace(issuerContent.Name))
            {
                issuerContent.Name = SetExecutableName();
            }
            if (string.IsNullOrWhiteSpace(issuerContent.Bundle))
            {
                issuerContent.Bundle = SetBundleName();
            }
            if (string.IsNullOrWhiteSpace(issuerContent.Type))
            {
                issuerContent.Type = SetDocumentType(entityTypes);
            }

            this.Content = issuerContent;

            executionData.SetPayload(new ExecutionApiRequestPayload()
            {
                Method = 2,
                Uri = payloadUri + "?bundle=" + issuerContent.Bundle,
                Data = issuerContent
            });

            return executionData;
        }
    }
}
