using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.PhoneNumberTypes;

/// <summary>
/// An enumerator describing phone number types
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class PhoneNumberType
{
    public static readonly PhoneNumberType Local = new(nameof(Local));
    public static readonly PhoneNumberType TollFree = new(nameof(TollFree));
    public static readonly PhoneNumberType Mobile = new(nameof(Mobile));
    public static readonly PhoneNumberType National = new(nameof(National));
    public static readonly PhoneNumberType SharedCost = new(nameof(SharedCost));
    public static readonly PhoneNumberType Landline = new(nameof(Landline));
    public static readonly PhoneNumberType Shortcode = new(nameof(Shortcode));
    public static readonly PhoneNumberType Longcode = new(nameof(Longcode));
    public static readonly PhoneNumberType Unknown = new(nameof(Unknown));
}