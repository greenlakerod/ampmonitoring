﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avanade.Amp.Core.Site
{
    public partial class SiteEntityWeb
    {
        private string mId;
        
        private string mAccountId;
        
        private string mName;
        
        private string mExternalIdentity;
        
        private string mAzureRegion;
        
        private bool mHosted;
        
        private string mAddress;
        
        private string mCity;
        
        private string mState;
        
        private string mPostalCode;
        
        private string mCountry;
        
        private System.Nullable<int> mTimeZone;
        
        private System.Nullable<double> mLatitude;
        
        private System.Nullable<double> mLongitude;
        
        private bool mAllowManualCredential;
        
        private Avanade.Amp.Core.Site.RdpConnectors mRdpConnector;
        
        private string mClusterId;
        
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
        
        public string AccountId
        {
            get
            {
                return this.mAccountId;
            }
            set
            {
                this.mAccountId = value;
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
        
        public string ExternalIdentity
        {
            get
            {
                return this.mExternalIdentity;
            }
            set
            {
                this.mExternalIdentity = value;
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
        
        public bool Hosted
        {
            get
            {
                return this.mHosted;
            }
            set
            {
                this.mHosted = value;
            }
        }
        
        public string Address
        {
            get
            {
                return this.mAddress;
            }
            set
            {
                this.mAddress = value;
            }
        }
        
        public string City
        {
            get
            {
                return this.mCity;
            }
            set
            {
                this.mCity = value;
            }
        }
        
        public string State
        {
            get
            {
                return this.mState;
            }
            set
            {
                this.mState = value;
            }
        }
        
        public string PostalCode
        {
            get
            {
                return this.mPostalCode;
            }
            set
            {
                this.mPostalCode = value;
            }
        }
        
        public string Country
        {
            get
            {
                return this.mCountry;
            }
            set
            {
                this.mCountry = value;
            }
        }
        
        public System.Nullable<int> TimeZone
        {
            get
            {
                return this.mTimeZone;
            }
            set
            {
                this.mTimeZone = value;
            }
        }
        
        public System.Nullable<double> Latitude
        {
            get
            {
                return this.mLatitude;
            }
            set
            {
                this.mLatitude = value;
            }
        }
        
        public System.Nullable<double> Longitude
        {
            get
            {
                return this.mLongitude;
            }
            set
            {
                this.mLongitude = value;
            }
        }
        
        public bool AllowManualCredential
        {
            get
            {
                return this.mAllowManualCredential;
            }
            set
            {
                this.mAllowManualCredential = value;
            }
        }
        
        public Avanade.Amp.Core.Site.RdpConnectors RdpConnector
        {
            get
            {
                return this.mRdpConnector;
            }
            set
            {
                this.mRdpConnector = value;
            }
        }
        
        public string ClusterId
        {
            get
            {
                return this.mClusterId;
            }
            set
            {
                this.mClusterId = value;
            }
        }
        
        public static SiteEntity ToSiteEntity(SiteEntityWeb site)
        {
            SiteEntity result = new SiteEntity();
            result.Id = site.Id;
            result.AccountId = site.AccountId;
            result.Name = site.Name;
            result.ExternalIdentity = site.ExternalIdentity;
            result.AzureRegion = site.AzureRegion;
            result.Hosted = site.Hosted;
            result.Address = site.Address;
            result.City = site.City;
            result.State = site.State;
            result.PostalCode = site.PostalCode;
            result.Country = site.Country;
            result.TimeZone = site.TimeZone;
            result.Latitude = site.Latitude;
            result.Longitude = site.Longitude;
            result.AllowManualCredential = site.AllowManualCredential;
            result.RdpConnector = site.RdpConnector;
            result.ClusterId = site.ClusterId;
            return result;
        }
        
        public static SiteEntityWeb ToSiteEntityWeb(SiteEntity site)
        {
            SiteEntityWeb result = new SiteEntityWeb();
            result.Id = site.Id;
            result.AccountId = site.AccountId;
            result.Name = site.Name;
            result.ExternalIdentity = site.ExternalIdentity;
            result.AzureRegion = site.AzureRegion;
            result.Hosted = site.Hosted;
            result.Address = site.Address;
            result.City = site.City;
            result.State = site.State;
            result.PostalCode = site.PostalCode;
            result.Country = site.Country;
            result.TimeZone = site.TimeZone;
            result.Latitude = site.Latitude;
            result.Longitude = site.Longitude;
            result.AllowManualCredential = site.AllowManualCredential;
            result.RdpConnector = site.RdpConnector;
            result.ClusterId = site.ClusterId;
            return result;
        }
    }
}
