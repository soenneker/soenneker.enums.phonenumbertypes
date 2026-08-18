using Soenneker.Gen.EnumValues;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Enums.PhoneNumberTypes;

/// <summary>
/// Classifies a telephone number by reach, billing model, network, or dialing format.
/// </summary>
[PublicOpenApiObject]
[EnumValue<string>]
public sealed partial class PhoneNumberType
{
    /// <summary>
    /// A number expressed in a local dialing format.
    /// </summary>
    public static readonly PhoneNumberType Local = new(nameof(Local));
    /// <summary>
    /// A toll-free number for which the recipient generally pays the call charges.
    /// </summary>
    public static readonly PhoneNumberType TollFree = new(nameof(TollFree));
    /// <summary>
    /// A number assigned to a mobile or cellular service.
    /// </summary>
    public static readonly PhoneNumberType Mobile = new(nameof(Mobile));
    /// <summary>
    /// A number expressed in a national dialing format.
    /// </summary>
    public static readonly PhoneNumberType National = new(nameof(National));
    /// <summary>
    /// A shared-cost number whose call charges are divided between caller and recipient.
    /// </summary>
    public static readonly PhoneNumberType SharedCost = new(nameof(SharedCost));
    /// <summary>
    /// A number assigned to a fixed-line telephone service.
    /// </summary>
    public static readonly PhoneNumberType Landline = new(nameof(Landline));
    /// <summary>
    /// A short code used for abbreviated dialing or messaging.
    /// </summary>
    public static readonly PhoneNumberType Shortcode = new(nameof(Shortcode));
    /// <summary>
    /// A standard-length number used for voice or messaging.
    /// </summary>
    public static readonly PhoneNumberType Longcode = new(nameof(Longcode));
    /// <summary>
    /// The phone-number classification could not be determined.
    /// </summary>
    public static readonly PhoneNumberType Unknown = new(nameof(Unknown));
}
