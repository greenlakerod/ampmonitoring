using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Avanade.Amp.Core.EntityAuditLog
{
    public class EntityAuditLog
    {
        /// <summary>
        /// Id
        /// </summary>
        
        public string Id { get; set; }

        /// <summary>
        /// Entity Id
        /// </summary>
        
        public string EntityId { get; set; }

        /// <summary>
        /// Entity's table name
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Action: create, update, delete
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// User Identity - identity of the user that is making the change
        /// </summary>
        public string UserIdentity { get; set; }

        /// <summary>
        /// Entity's column name that is changed
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// New value
        /// </summary>
        public string NewValue { get; set; }
        
        /// <summary>
        /// Original Value
        /// </summary>
        public string OriginalValue { get; set; }

        /// <summary>
        /// Change timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }

        public string EntityAuditCommentId { get; set; }

        
        public virtual EntityAuditComment EntityAuditComment { get; set; }
    }
}