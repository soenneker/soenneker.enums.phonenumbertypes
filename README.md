[![](https://img.shields.io/nuget/v/soenneker.enums.phonenumbertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.phonenumbertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.phonenumbertypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.phonenumbertypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.phonenumbertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.phonenumbertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.phonenumbertypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.phonenumbertypes/actions/workflows/codeql.yml)

# Soenneker.Enums.PhoneNumberTypes

A string-backed enum-value type for carrying a provider or application-supplied telephone-number classification.

## Install

```bash
dotnet add package Soenneker.Enums.PhoneNumberTypes
```

## Usage

```csharp
using Soenneker.Enums.PhoneNumberTypes;

PhoneNumberType numberType = PhoneNumberType.TollFree;
string wireValue = numberType.Value; // "TollFree"

if (PhoneNumberType.TryFromValue(providerValue, out PhoneNumberType? parsed))
{
    // parsed is one of the shared static instances
}
```

Available values:

- Dialing scope or format: `Local`, `National`, `Shortcode`, `Longcode`
- Service or billing category: `TollFree`, `SharedCost`, `Mobile`, `Landline`
- Unclassified: `Unknown`

`System.Text.Json` serializes the type as the shown string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` for provider or request values. `FromName` and `TryFromName` are also generated.

The values span different classification dimensions and are not inherently mutually exclusive—a mobile number can also be written in a national format, for example. Use the type only where the surrounding contract defines one expected dimension. This package does not parse, normalize, validate, reach, or look up phone numbers, and its values must not be treated as identity or fraud evidence.
