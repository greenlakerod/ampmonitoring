using System;


namespace Avanade.Amp.Core.EntityAuditLog
{
    
    public class EntityAuditLogPrefetchWeb
    {
        public EntityAuditLogPrefetchWeb()
        {
        }

        public EntityAuditLogPrefetchWeb(EntityAuditLog entityAuditLog)
        {
            Id = entityAuditLog.Id;
            EntityId = entityAuditLog.EntityId;
            TableName = entityAuditLog.TableName;
            UserIdentity = entityAuditLog.UserIdentity;
            ColumnName = entityAuditLog.ColumnName;
            NewValue = entityAuditLog.NewValue;
            OriginalValue = entityAuditLog.OriginalValue;
            Timestamp = entityAuditLog.Timestamp;
            Comment = entityAuditLog.EntityAuditComment?.Comment;
        }

        public string Id { get; set; }
        public string EntityId { get; set; }
        public string TableName { get; set; }
        public string Action { get; set; }
        public string UserIdentity { get; set; }
        public string ColumnName { get; set; }
        public string NewValue { get; set; }
        public string OriginalValue { get; set; }
        public DateTime Timestamp { get; set; }
        public string Comment { get; set; }
    }
}
