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

namespace Avanade.Amp.Core.Target
{
    public partial class TargetWeb
    {
        private string mId;
        
        private string mName;
        
        private string mSiteId;
        
        private string mType;
        
        private string mExternalIdentity;
        
        private string mTenant;
        
        private string mTenantDisplayName;
        
        private System.Collections.Generic.IDictionary<string, object> mProperties;
        
        private System.Collections.Generic.IEnumerable<string> mEndpoints;
        
        private bool mShouldBeMonitored;
        
        private System.Nullable<System.DateTime> mCreatedDate;
        
        private System.Nullable<System.DateTime> mLastModifiedDate;
        
        private string mLastModifiedBy;
        
        private string mCreatedBy;
        
        private byte[] mRowVersion;
        
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
        
        public string SiteId
        {
            get
            {
                return this.mSiteId;
            }
            set
            {
                this.mSiteId = value;
            }
        }
        
        public string Type
        {
            get
            {
                return this.mType;
            }
            set
            {
                this.mType = value;
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
        
        public string Tenant
        {
            get
            {
                return this.mTenant;
            }
            set
            {
                this.mTenant = value;
            }
        }
        
        public string TenantDisplayName
        {
            get
            {
                return this.mTenantDisplayName;
            }
            set
            {
                this.mTenantDisplayName = value;
            }
        }
        
        public System.Collections.Generic.IDictionary<string, object> Properties
        {
            get
            {
                return this.mProperties;
            }
            set
            {
                this.mProperties = value;
            }
        }
        
        public System.Collections.Generic.IEnumerable<string> Endpoints
        {
            get
            {
                return this.mEndpoints;
            }
            set
            {
                this.mEndpoints = value;
            }
        }
        
        public bool ShouldBeMonitored
        {
            get
            {
                return this.mShouldBeMonitored;
            }
            set
            {
                this.mShouldBeMonitored = value;
            }
        }
        
        public System.Nullable<System.DateTime> CreatedDate
        {
            get
            {
                return this.mCreatedDate;
            }
            set
            {
                this.mCreatedDate = value;
            }
        }
        
        public System.Nullable<System.DateTime> LastModifiedDate
        {
            get
            {
                return this.mLastModifiedDate;
            }
            set
            {
                this.mLastModifiedDate = value;
            }
        }
        
        public string LastModifiedBy
        {
            get
            {
                return this.mLastModifiedBy;
            }
            set
            {
                this.mLastModifiedBy = value;
            }
        }
        
        public string CreatedBy
        {
            get
            {
                return this.mCreatedBy;
            }
            set
            {
                this.mCreatedBy = value;
            }
        }
        
        public byte[] RowVersion
        {
            get
            {
                return this.mRowVersion;
            }
            set
            {
                this.mRowVersion = value;
            }
        }
        
        public static Target ToTarget(TargetWeb target)
        {
            Target result = new Target();
            result.Id = target.Id;
            result.Name = target.Name;
            result.SiteId = target.SiteId;
            result.Type = target.Type;
            result.ExternalIdentity = target.ExternalIdentity;
            result.Tenant = target.Tenant;
            result.TenantDisplayName = target.TenantDisplayName;
            result.Properties = target.Properties;
            result.Endpoints = target.Endpoints;
            result.ShouldBeMonitored = target.ShouldBeMonitored;
            result.CreatedDate = target.CreatedDate;
            result.LastModifiedDate = target.LastModifiedDate;
            result.LastModifiedBy = target.LastModifiedBy;
            result.CreatedBy = target.CreatedBy;
            result.RowVersion = target.RowVersion;
            return result;
        }
        
        public static TargetWeb ToTargetWeb(Target target)
        {
            TargetWeb result = new TargetWeb();
            result.Id = target.Id;
            result.Name = target.Name;
            result.SiteId = target.SiteId;
            result.Type = target.Type;
            result.ExternalIdentity = target.ExternalIdentity;
            result.Tenant = target.Tenant;
            result.TenantDisplayName = target.TenantDisplayName;
            result.Properties = target.Properties;
            result.Endpoints = target.Endpoints;
            result.ShouldBeMonitored = target.ShouldBeMonitored;
            result.CreatedDate = target.CreatedDate;
            result.LastModifiedDate = target.LastModifiedDate;
            result.LastModifiedBy = target.LastModifiedBy;
            result.CreatedBy = target.CreatedBy;
            result.RowVersion = target.RowVersion;
            return result;
        }
    }

}