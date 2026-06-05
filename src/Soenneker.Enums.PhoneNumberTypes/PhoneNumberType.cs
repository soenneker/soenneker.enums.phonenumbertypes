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
    /// <summary>
    /// The local.
    /// </summary>
    public static readonly PhoneNumberType Local = new(nameof(Local));
    /// <summary>
    /// The toll free.
    /// </summary>
    public static readonly PhoneNumberType TollFree = new(nameof(TollFree));
    /// <summary>
    /// The mobile.
    /// </summary>
    public static readonly PhoneNumberType Mobile = new(nameof(Mobile));
    /// <summary>
    /// The national.
    /// </summary>
    public static readonly PhoneNumberType National = new(nameof(National));
    /// <summary>
    /// The shared cost.
    /// </summary>
    public static readonly PhoneNumberType SharedCost = new(nameof(SharedCost));
    /// <summary>
    /// The landline.
    /// </summary>
    public static readonly PhoneNumberType Landline = new(nameof(Landline));
    /// <summary>
    /// The shortcode.
    /// </summary>
    public static readonly PhoneNumberType Shortcode = new(nameof(Shortcode));
    /// <summary>
    /// The longcode.
    /// </summary>
    public static readonly PhoneNumberType Longcode = new(nameof(Longcode));
    /// <summary>
    /// The unknown.
    /// </summary>
    public static readonly PhoneNumberType Unknown = new(nameof(Unknown));
}