﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avanade.Amp.Core.Logs
{
    public partial class RdpLogWeb
    {
        
        private string mId;
        
        private string mUserIdentity;
        
        private System.DateTime mStartTimeUtc;
        
        private System.Nullable<System.DateTime> mEndTimeUtc;
        
        private string mAccountExternalIdentity;
        
        private string mAccountIdentity;
        
        private string mAccountName;
        
        private string mSiteExternalIdentity;
        
        private string mSiteIdentity;
        
        private string mSiteName;
        
        private string mHopSiteIdentity;
        
        private string mHopSiteName;
        
        private string mTargetIdentity;
        
        private string mTargetName;
        
        private string mConnectionIdentity;
        
        private long mBytesSent;
        
        private long mBytesReceived;
        
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
        
        public string UserIdentity
        {
            get
            {
                return this.mUserIdentity;
            }
            set
            {
                this.mUserIdentity = value;
            }
        }
        
        public System.DateTime StartTimeUtc
        {
            get
            {
                return this.mStartTimeUtc;
            }
            set
            {
                this.mStartTimeUtc = value;
            }
        }
        
        public System.Nullable<System.DateTime> EndTimeUtc
        {
            get
            {
                return this.mEndTimeUtc;
            }
            set
            {
                this.mEndTimeUtc = value;
            }
        }
        
        public string AccountExternalIdentity
        {
            get
            {
                return this.mAccountExternalIdentity;
            }
            set
            {
                this.mAccountExternalIdentity = value;
            }
        }
        
        public string AccountIdentity
        {
            get
            {
                return this.mAccountIdentity;
            }
            set
            {
                this.mAccountIdentity = value;
            }
        }
        
        public string AccountName
        {
            get
            {
                return this.mAccountName;
            }
            set
            {
                this.mAccountName = value;
            }
        }
        
        public string SiteExternalIdentity
        {
            get
            {
                return this.mSiteExternalIdentity;
            }
            set
            {
                this.mSiteExternalIdentity = value;
            }
        }
        
        public string SiteIdentity
        {
            get
            {
                return this.mSiteIdentity;
            }
            set
            {
                this.mSiteIdentity = value;
            }
        }
        
        public string SiteName
        {
            get
            {
                return this.mSiteName;
            }
            set
            {
                this.mSiteName = value;
            }
        }
        
        public string HopSiteIdentity
        {
            get
            {
                return this.mHopSiteIdentity;
            }
            set
            {
                this.mHopSiteIdentity = value;
            }
        }
        
        public string HopSiteName
        {
            get
            {
                return this.mHopSiteName;
            }
            set
            {
                this.mHopSiteName = value;
            }
        }
        
        public string TargetIdentity
        {
            get
            {
                return this.mTargetIdentity;
            }
            set
            {
                this.mTargetIdentity = value;
            }
        }
        
        public string TargetName
        {
            get
            {
                return this.mTargetName;
            }
            set
            {
                this.mTargetName = value;
            }
        }
        
        public string ConnectionIdentity
        {
            get
            {
                return this.mConnectionIdentity;
            }
            set
            {
                this.mConnectionIdentity = value;
            }
        }
        
        public long BytesSent
        {
            get
            {
                return this.mBytesSent;
            }
            set
            {
                this.mBytesSent = value;
            }
        }
        
        public long BytesReceived
        {
            get
            {
                return this.mBytesReceived;
            }
            set
            {
                this.mBytesReceived = value;
            }
        }
        
        public static RdpLog ToRdpLog(RdpLogWeb rdp)
        {
            RdpLog result = new RdpLog();
            result.Id = rdp.Id;
            result.UserIdentity = rdp.UserIdentity;
            result.StartTimeUtc = rdp.StartTimeUtc;
            result.EndTimeUtc = rdp.EndTimeUtc;
            result.AccountExternalIdentity = rdp.AccountExternalIdentity;
            result.AccountIdentity = rdp.AccountIdentity;
            result.AccountName = rdp.AccountName;
            result.SiteExternalIdentity = rdp.SiteExternalIdentity;
            result.SiteIdentity = rdp.SiteIdentity;
            result.SiteName = rdp.SiteName;
            result.HopSiteIdentity = rdp.HopSiteIdentity;
            result.HopSiteName = rdp.HopSiteName;
            result.TargetIdentity = rdp.TargetIdentity;
            result.TargetName = rdp.TargetName;
            result.ConnectionIdentity = rdp.ConnectionIdentity;
            result.BytesSent = rdp.BytesSent;
            result.BytesReceived = rdp.BytesReceived;
            return result;
        }
        
        public static RdpLogWeb ToRdpLogWeb(RdpLog rdp)
        {
            RdpLogWeb result = new RdpLogWeb();
            result.Id = rdp.Id;
            result.UserIdentity = rdp.UserIdentity;
            result.StartTimeUtc = rdp.StartTimeUtc;
            result.EndTimeUtc = rdp.EndTimeUtc;
            result.AccountExternalIdentity = rdp.AccountExternalIdentity;
            result.AccountIdentity = rdp.AccountIdentity;
            result.AccountName = rdp.AccountName;
            result.SiteExternalIdentity = rdp.SiteExternalIdentity;
            result.SiteIdentity = rdp.SiteIdentity;
            result.SiteName = rdp.SiteName;
            result.HopSiteIdentity = rdp.HopSiteIdentity;
            result.HopSiteName = rdp.HopSiteName;
            result.TargetIdentity = rdp.TargetIdentity;
            result.TargetName = rdp.TargetName;
            result.ConnectionIdentity = rdp.ConnectionIdentity;
            result.BytesSent = rdp.BytesSent;
            result.BytesReceived = rdp.BytesReceived;
            return result;
        }
    }
}
