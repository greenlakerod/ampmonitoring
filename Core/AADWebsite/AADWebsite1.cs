﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avanade.Amp.Core.AADWebsite
{
    public partial class AADWebsiteWeb
    {
        
        private string mId;
        
        private string mName;
        
        private string mAzureRegion;
        
        private string mAADAppId;
        
        private bool mSiteLinkUse;
        
        private string mWebSpaceName;
        
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
        
        public string Name
        {
            get
            {
                return this.mName;
            }
            set
            {
                this.mName = value;
            }
        }
        
        public string AzureRegion
        {
            get
            {
                return this.mAzureRegion;
            }
            set
            {
                this.mAzureRegion = value;
            }
        }
        
        public string AADAppId
        {
            get
            {
                return this.mAADAppId;
            }
            set
            {
                this.mAADAppId = value;
            }
        }
        
        public bool SiteLinkUse
        {
            get
            {
                return this.mSiteLinkUse;
            }
            set
            {
                this.mSiteLinkUse = value;
            }
        }
        
        public string WebSpaceName
        {
            get
            {
                return this.mWebSpaceName;
            }
            set
            {
                this.mWebSpaceName = value;
            }
        }
        
        public static AADWebsite ToAADWebsite(AADWebsiteWeb website)
        {
            AADWebsite result = new AADWebsite();
            result.Id = website.Id;
            result.Name = website.Name;
            result.AzureRegion = website.AzureRegion;
            result.AADAppId = website.AADAppId;
            result.SiteLinkUse = website.SiteLinkUse;
            result.WebSpaceName = website.WebSpaceName;
            return result;
        }
        
        public static AADWebsiteWeb ToAADWebsiteWeb(AADWebsite website)
        {
            AADWebsiteWeb result = new AADWebsiteWeb();
            result.Id = website.Id;
            result.Name = website.Name;
            result.AzureRegion = website.AzureRegion;
            result.AADAppId = website.AADAppId;
            result.SiteLinkUse = website.SiteLinkUse;
            result.WebSpaceName = website.WebSpaceName;
            return result;
        }
    }
}
