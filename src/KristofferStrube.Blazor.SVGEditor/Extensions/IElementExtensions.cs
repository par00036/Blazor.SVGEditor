using AngleSharp.Dom;
using System.Globalization;
using System.Numerics;

namespace KristofferStrube.Blazor.SVGEditor.Extensions;

public static class IElementExtensions
{
    public static T GetAttributeOrZero<T>(this IElement element, string attribute) where T : INumber<T>
    {
        string? attributeValue = element.GetAttribute(attribute);
        return string.IsNullOrWhiteSpace(attributeValue) ? T.Zero : T.Parse(attributeValue, CultureInfo.InvariantCulture);
    }

    public static T GetAttributeOrOne<T>(this IElement element, string attribute) where T : INumber<T>
    {
        string? attributeValue = element.GetAttribute(attribute);
        return string.IsNullOrWhiteSpace(attributeValue) ? T.One : T.Parse(attributeValue, CultureInfo.InvariantCulture);
    }

    public static double GetAttributeOrZero(this IElement element, string attribute)
    {
        return element.GetAttributeOrZero<double>(attribute);
    }

    public static double GetAttributeOrOne(this IElement element, string attribute)
    {
        return element.GetAttributeOrOne<double>(attribute);
    }

    public static string GetAttributeOrEmpty(this IElement element, string attribute)
    {
        string? attributeValue = element.GetAttribute(attribute);
        return string.IsNullOrWhiteSpace(attributeValue) ? string.Empty : attributeValue;
    }
}
