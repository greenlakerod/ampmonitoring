// Copyright © 2015 - Avanade, Inc.

using System.Collections.Generic;
using Avanade.Amp.Core.Extensions;
using Avanade.Amp.Core.Site;

using Newtonsoft.Json;

namespace Avanade.Amp.Core.Target
{
    public class Target : TrackedEntityBase
    {
        /// <summary>
        /// Internal ID, primary key in database, a string of a guid.
        /// </summary>
        
        
        public string Id { get; set; }

        /// <summary>
        /// The name of the target, typically a computer name.
        /// </summary>
        
        public string Name { get; set; }

        /// <summary>
        /// The foreign key to the Site in the database, a string of a guid.
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// Target type, such as adsimple, ampsiteserver, cisconexus, dpm, exchange, f5bigip, hyperv, mssql, nimble, officewebapp, sharepoint, skypeforbusiness, windows
        /// </summary>
        
        public string Type { get; set; }

        /// <summary>
        /// The ID in the foreign system that created the targets, (e.g. the Service Now configuration item's sys_id)
        /// </summary>
        
        public string ExternalIdentity { get; set; }

        /// <summary>
        /// The ID in the foreign system of the tenant object this target belongs to, (e.g. the Service Now company's sys_id)
        /// </summary>
        
        public string Tenant { get; set; }

        /// <summary>
        /// The display name of the foreign system's tenant object (e.g. the Service Now company name)
        /// </summary>
        
        public string TenantDisplayName { get; set; }

        /// <summary>
        /// This is the dictionary of properties that is backed by a JSON string in the database.
        /// </summary>
        /// <see cref="PropertiesJson"/>
        public IDictionary<string, object> Properties { get; set; }

        /// <summary>
        /// This is the backing store for the dictionary of properties in the database.
        /// </summary>
        /// <see cref="Properties"/>
        
        public string PropertiesJson
        {
            get { return JsonConvert.SerializeObject(Properties); }
            set
            {
                Properties = value == null ? null : JsonConvertExt.DeserializeObject(value);
            }
        }

        /// <summary>
        /// This is the array of endpoints that is backed by a JSON string in the database.
        /// </summary>
        /// <see cref="EndpointsJson"/>
        public IEnumerable<string> Endpoints { get; set; }

        /// <summary>
        /// This is the backing store for the array of endpoints in the database.
        /// </summary>
        /// <see cref="Endpoints"/>
        
        public string EndpointsJson
        {
            get { return JsonConvert.SerializeObject(Endpoints); }
            set
            {
                Endpoints = value == null ? null : JsonConvert.DeserializeObject<IEnumerable<string>>(value);
            }
        }

        /// <summary>
        /// Should monitoring probe this target?
        /// </summary>
        public bool ShouldBeMonitored { get; set; }

        /// <summary>
        /// This is hydrated by the store by following SiteId.
        /// </summary>
        /// <see cref="SiteId"/>
        
        public virtual SiteEntity Site { get; set; }

        
        public virtual List<VaultCredential> VaultCredentials { get; set; }

        /// <summary>
        /// This copies all of the properties from another target, except the ID, since we assume the destination came from the database.
        /// </summary>
        /// <param name="src"></param>
        public void Copy(Target src)
        {
            Name = src.Name;
            Type = src.Type;
            if (SiteId != src.SiteId)
            {
                SiteId = src.SiteId;
                Site = src.Site;
            }
            ExternalIdentity = src.ExternalIdentity;
            Tenant = src.Tenant;
            TenantDisplayName = src.TenantDisplayName;
            Endpoints = src.Endpoints;
            Properties = src.Properties;
            ShouldBeMonitored = src.ShouldBeMonitored;
        }

        public override string GetId()
        {
            return Id;
        }
    }
}