using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanade.Amp.Common.Api.Probe
{
    public class Probe : Executable, IExecutableContent
    {
        private ProbeExecutionType _executionType = ProbeExecutionType.Execute;

        public string Bundle { get; set; }
        public string Description { get; set; }
        public ExecutableType ExecutableType { get; set; }
        public string Name { get; set; }

        public Probe(ExecutingFile file, ProbeExecutionType? executionType): base(file)
        {
            if (executionType.HasValue)
            {
                _executionType = executionType.Value;
            }
        }

        public override ExecutionData SetExecutionData()
        {
            ExecutionData executionData = new ExecutionData();
            ProbeContent probeContent = JsonConvert.DeserializeObject<ProbeContent>(_executingFile.Content);
            probeContent.ExecutableType = ExecutableType.Probe;

            if (_executionType == ProbeExecutionType.TestFilter)
            {
                executionData.Resource = string.Format(Constants.URI_TARGETS_FILTER_BY_SITE, Settings.Settings.Site.Id);
                string filter = "";

                if (!string.IsNullOrWhiteSpace(probeContent.Filter))
                {
                    filter = probeContent.Filter;
                }
                else
                {
                    Dictionary<string, object> propertyBag = new Dictionary<string, object>();
                    propertyBag.Add("filter", "");

                    AddExternalFileContent(propertyBag);
                    filter = (string)propertyBag["filter"];
                }

                executionData.SetPayload(filter);
            }
            else if (_executionType == ProbeExecutionType.PercolateResults)
            {
                executionData.Resource = string.Format(Constants.URI_SITES_TEST_RENDER_ISSUES, Settings.Settings.Site.Id);
                executionData.SetPayload(""); //todo: set to the content of the execute probe results
            }
            else
            {
                Target.Target target = Settings.Settings.Target;
                
                if (target.TargetEndpoints == null || target.TargetEndpoints.Count() == 0)
                {
                    target.TargetEndpoints = new List<Target.TargetEndpoint>();
                    if (target.Endpoints != null)
                    {
                        foreach (string endpoint in target.Endpoints)
                        {
                            ((List<Target.TargetEndpoint>)target.TargetEndpoints).Add(SetTargetEndpoint(endpoint));
                        }
                    }
                }

                //add content of scripts, etc
                AddExternalFileContent(probeContent.Parameters);

                //add other required properties
                if (string.IsNullOrWhiteSpace(probeContent.Name))
                {
                    probeContent.Name = SetExecutableName();
                }
                if (string.IsNullOrWhiteSpace(probeContent.Bundle))
                {
                    probeContent.Bundle = SetBundleName().ToLower();
                }

                executionData.Resource = string.Format(Constants.URI_SITES_PROXY, Settings.Settings.Site.Id);

                ExecutionApiRequestPayload payload = new ExecutionApiRequestPayload() { Method = 2 };
                IApiRequestPayloadData payloadData;

                if (_executionType == ProbeExecutionType.Execute)
                {
                    payload.Uri = string.Format(Constants.URI_PROBE_EXECUTE, probeContent.Provider, probeContent.Bundle);
                    payloadData = new ProbeExecuteApiRequestPayloadData()
                    {
                        Probe = probeContent,
                        Target = target
                    };
                }
                else //if (_executionType == ProbeExecutionType.Query)
                {
                    payload.Uri = string.Format(Constants.URI_PROBE_QUERY, probeContent.Provider, probeContent.Bundle);
                    payloadData = new ProbeQueryApiRequestPayloadData()
                    {
                        Parameters = probeContent.Parameters,
                        Target = target
                    };
                }

                payload.Data = payloadData;
                executionData.SetPayload(payload);
            }

            this.Content = probeContent;

            return executionData;
        }

        private Target.TargetEndpoint SetTargetEndpoint(string url)
        {
            Uri uri = new Uri(url);
            Target.TargetEndpoint targetEndpoint = new Target.TargetEndpoint()
            {
                Uri = url,
                Protocol = uri.Scheme + ":",
                Host = uri.Host,
                Path = !string.IsNullOrWhiteSpace(uri.AbsolutePath) ? uri.AbsolutePath : "",
                Query = !string.IsNullOrWhiteSpace(uri.Query) ? uri.Query : "",
                Fragment = !string.IsNullOrWhiteSpace(uri.Fragment) ? uri.Fragment : ""
            };

            return targetEndpoint;
        }

        //todo: called when query probe call returns
        private void ReplaceProperties()
        {

        }
    }
}
