using System;
using System.Reflection;

namespace MitarashiDango.AvatarUtils.Core.Attribute
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class DeprecatedAttribute : System.Attribute
    {
        public static bool IsDeprecated(Type type)
        {
            var attr = type.GetCustomAttribute<DeprecatedAttribute>();
            if (attr == null)
            {
                return false;
            }

            return true;
        }
    }
}