using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Adapter.Interface;

namespace SimpleAdapterCSharp
{
    public class JsonParser<T> : IJsonParser<T>
    {
        public T Parse(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
 
        public string ConvertToJson(T obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}