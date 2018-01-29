using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppConfig
{
    public static class Configuration
    {
        public static T Get<T>(string keyName)
        {
            if (typeof(T) == typeof(string))
                return (T)(object)(ConfigurationManager.AppSettings[keyName] ?? String.Empty);

            if (typeof(T) == typeof(int))
                return (T)(object)Int32.Parse(ConfigurationManager.AppSettings[keyName] ?? "0");

            if (typeof(T) == typeof(long))
                return (T)(object)Int64.Parse(ConfigurationManager.AppSettings[keyName] ?? "0");

            if (typeof(T) == typeof(double))
                return (T)(object)Double.Parse(ConfigurationManager.AppSettings[keyName] ?? "0");

            if (typeof(T) == typeof(bool))
                return (T)(object)Boolean.Parse(ConfigurationManager.AppSettings[keyName] ?? "false");
            if (typeof(T) == typeof(TimeSpan))
                return (T)(object)TimeSpan.Parse(ConfigurationManager.AppSettings[keyName] ?? "0");

            return (T)(object)null;
        }
    }
}
