using System.ComponentModel;
using System.Reflection;

namespace Zoologico;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = (field ?? throw new InvalidOperationException()).GetCustomAttribute<DescriptionAttribute>();

        return attribute == null ? value.ToString() : attribute.Description;
    }
}