using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Laboratorium3___Employee.Models
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            DisplayAttribute attrib = enumValue.GetType()
                                               .GetMember(enumValue.ToString())
                                               .First()
                                               .GetCustomAttribute<DisplayAttribute>();

            if (attrib is null) return enumValue.ToString();

            return attrib.GetName();
        }
    }
}
