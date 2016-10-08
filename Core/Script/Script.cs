// Copyright © 2014 - Avanade Inc.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Avanade.Amp.Core.Script
{
    public class Script
    { 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public string CategoriesJson
        {
            get { return JsonConvert.SerializeObject(Categories); }
            set
            {
                Categories = value == null ? null : JsonConvert.DeserializeObject<IEnumerable<string>>(value);
            }
        }
        public IEnumerable<ScriptParameter> Parameters { get; set; }
    }
}