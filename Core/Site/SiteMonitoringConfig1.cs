﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.Site
{
    public partial class SiteMonitoringConfigWeb
    {
        private string mId;      
        private string mElasticsearchDataLocationPath;
        
        public string Id
        {
            get
            {
                return this.mId;
            }
            set
            {
                this.mId = value;
            }
        }
        
        public string ElasticsearchDataLocationPath
        {
            get
            {
                return this.mElasticsearchDataLocationPath;
            }
            set
            {
                this.mElasticsearchDataLocationPath = value;
            }
        }
        
        public static SiteMonitoringConfig ToSiteMonitoringConfig(SiteMonitoringConfigWeb siteMonitoringConfig)
        {
            SiteMonitoringConfig result = new SiteMonitoringConfig();
            result.Id = siteMonitoringConfig.Id;
            result.ElasticsearchDataLocationPath = siteMonitoringConfig.ElasticsearchDataLocationPath;
            return result;
        }
        
        public static SiteMonitoringConfigWeb ToSiteMonitoringConfigWeb(SiteMonitoringConfig siteMonitoringConfig)
        {
            SiteMonitoringConfigWeb result = new SiteMonitoringConfigWeb();
            result.Id = siteMonitoringConfig.Id;
            result.ElasticsearchDataLocationPath = siteMonitoringConfig.ElasticsearchDataLocationPath;
            return result;
        }
    }
}
