// Copyright © 2015 - Avanade, Inc.

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Avanade.Amp.Core.Extensions
{
    /// <summary>
    /// Start of a class to convert JObjects into CLR objects...
    /// So far it just takes top level string arrays and turns them into List&lt;string&gt; rathar than JArray
    /// </summary>
    public class JsonConvertExt
    {
        public static IDictionary<string, object> DeserializeObject(string json)
        {
            var dict = JsonConvert.DeserializeObject<IDictionary<string, object>>(json);
            if (dict == null) return null;
            var replacements = new Dictionary<string, object>();
            foreach (var item in dict)
            {
                var value = item.Value;
                var type = value.GetType().Name;
                switch (type)
                {
                    case "JArray":
                        var ja = (JArray)value;
                        replacements[item.Key] = ConvertToClrType(ja, UniformType(ja));
                        break;
                    // if we want to convert other types, do it here.
                    default:
                        replacements[item.Key] = item.Value;
                        break;
                }
            }
            return replacements;
        }

        private static JTokenType UniformType(JArray ja)
        {
            var type = JTokenType.None;
            foreach (var val in ja)
            {
                if (type == JTokenType.None)
                {
                    type = val.Type;
                }
                else
                {
                    if (type != val.Type)
                    {
                        return JTokenType.None;
                    }
                }
            }
            return type;
        }

        private static object ConvertToClrType(JArray ja, JTokenType arrayType)
        {
            if (!ja.HasValues)
            {
                return new List<object>();
            }
            switch (arrayType)
            {
                case JTokenType.String:
                    return ja.Select(val => val.Value<string>()).ToList();
                // TODO: other types here.  Number, boolean, object, array... (recurse).
                default:
                    return ja;
            }
        }
    }
}