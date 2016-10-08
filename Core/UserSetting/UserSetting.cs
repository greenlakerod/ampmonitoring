// Copyright © 2015 - Avanade Inc.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avanade.Amp.Core.UserSetting
{
    public class UserSetting
    {
        public string Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string UserIdentity { get; set; }
    }
}