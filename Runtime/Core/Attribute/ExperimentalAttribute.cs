using System;
using System.Reflection;

namespace MitarashiDango.AvatarUtils.Core.Attribute
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class ExperimentalAttribute : System.Attribute
    {
        public static bool IsExperimental(Type type)
        {
            var attr = type.GetCustomAttribute<ExperimentalAttribute>();
            if (attr == null)
            {
                return false;
            }

            return true;
        }
    }
}