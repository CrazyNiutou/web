using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Common
{
  public static  class NewtonsoftExtensions
    {
        public static string JsonSerializeObjectShortDate(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { DateFormatString = "yyyy-MM-dd hh:mm:ss" });
        }
    }
}
