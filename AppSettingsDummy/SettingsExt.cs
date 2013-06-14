using System;
using System.Linq.Expressions;
using AppSettingsDummy.Properties;

namespace AppSettingsDummy
{
    internal static class SettingsExt
    {
        public static void SetValue<T>(this Settings settings, Expression<Func<Settings, T>> property, T value)
        {
            string name = ((MemberExpression) property.Body).Member.Name;
            settings[name] = value;
        }
    }
}