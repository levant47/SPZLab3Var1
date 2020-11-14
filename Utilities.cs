using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SPZLab3Var1
{
    public static class Utilities
    {
        public static int? SafeParseInt(string source) => int.TryParse(source, out var result) ? (int?)result : null;

        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(value.GetType(), value);
            return (Attribute.GetCustomAttribute(type.GetField(name), typeof(DescriptionAttribute)) as DescriptionAttribute)
                ?.Description;
        }

        public static string[] GetAllDescriptions(this Type enumType) => Enum.GetValues(enumType)
            .Cast<Enum>()
            .Select(GetDescription)
            .ToArray();

        public static T GetEnumByDescription<T>(this string targetDescription) =>
            (T)typeof(T).GetFields()
                .FirstOrDefault(field =>
                    (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description == targetDescription)
                .GetValue(null);

        public static List<T> GetAllEnumValues<T>() => Enum.GetValues(typeof(T)).Cast<T>().ToList();

        public static T GetRandomElement<T>(this List<T> source) => source[new Random().Next(0, source.Count())];
    }
}
