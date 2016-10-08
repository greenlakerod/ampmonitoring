using System.Collections.Generic;

namespace Avanade.Amp.Core.EntityAuditLog
{
    public class EntityAuditComment
    {
        public string Id { get; set; }
        public string Comment { get; set; }
        
        public virtual List<EntityAuditLog> EntityAuditLogs { get; set; }
    }
}
