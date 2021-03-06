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


namespace Avanade.Amp.Core.Timezone
{
    public partial class TimeZoneWeb
    {
        
        private int mId;
        
        private string mName;
        
        private string mOffset;
        
        public int Id
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
        
        public string Offset
        {
            get
            {
                return this.mOffset;
            }
            set
            {
                this.mOffset = value;
            }
        }
        
        public static TimeZone ToTimeZone(TimeZoneWeb timeZone)
        {
            TimeZone result = new TimeZone();
            result.Id = timeZone.Id;
            result.Name = timeZone.Name;
            result.Offset = timeZone.Offset;
            return result;
        }
        
        public static TimeZoneWeb ToTimeZoneWeb(TimeZone timeZone)
        {
            TimeZoneWeb result = new TimeZoneWeb();
            result.Id = timeZone.Id;
            result.Name = timeZone.Name;
            result.Offset = timeZone.Offset;
            return result;
        }
    }
}
