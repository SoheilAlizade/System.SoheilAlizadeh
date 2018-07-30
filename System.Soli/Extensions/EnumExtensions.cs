using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace System.Soli.Extensions
{
    public static class EnumExtensions
    {
        public static string GetName(this Enum enumValue)
        {
            var member = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();

            return member == null ? "-" : member .GetCustomAttribute<DisplayAttribute>().GetName();
        }
        
        public static string GetName<T>(this T enumValue)
        {
            var member = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault();

            return member == null ? "-" : member .GetCustomAttribute<DisplayAttribute>().GetName();
        }
    }
}