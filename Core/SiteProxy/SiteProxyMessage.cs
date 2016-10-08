// Copyright © 2015 - Avanade Inc.

namespace Avanade.Amp.Core.SiteProxy
{
    public enum ProxyHttpMethod
    {
        BadRequest = 0,
        Get = 1,
        Post = 2,
        Put = 3,
        Delete = 4
    }

    public class SiteProxyMessage
    {
        public string Id { get; set; }

        public ProxyHttpMethod Method { get; set; }
        public string Uri { get; set; }
        public object Data { get; set; }

        public bool IsIntegrationAllowed
        {
            get
            {
                if (Uri != null && Uri.StartsWith("/monitoring/api/v1/issues"))
                {
                    return true;
                }
                return false;
            }
        }
    }
}