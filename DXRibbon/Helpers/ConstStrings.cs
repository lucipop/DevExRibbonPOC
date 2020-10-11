using System.Reflection;

namespace DXRibbon.Helpers
{
    public class ConstStrings
    {
        public static string Get(string name)
        {
            return GetDefault(name);
        }
        static string GetDefault(string name)
        {
            PropertyInfo pi = typeof(Properties.Resources).GetProperty(name);
            return string.Format("{0}", pi.GetValue(null, new object[] { }));
        }
    }
}
