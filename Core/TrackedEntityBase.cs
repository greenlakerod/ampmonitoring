// Copyright © 2015 - Avanade Inc.

using System;

namespace Avanade.Amp.Core
{
    public abstract class TrackedEntityBase
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVersion { get; set; }

        public abstract string GetId();
    }
}