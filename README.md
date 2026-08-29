[![](https://img.shields.io/nuget/v/soenneker.enums.phonenumbertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.phonenumbertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.phonenumbertypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.phonenumbertypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.phonenumbertypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.phonenumbertypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.phonenumbertypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.phonenumbertypes/actions/workflows/codeql.yml)

# Soenneker.Enums.PhoneNumberTypes

Classifies a telephone number by reach, billing model, network, or dialing format.

## Install

```bash
dotnet add package Soenneker.Enums.PhoneNumberTypes
```

## What you get

- `PhoneNumberType` — Classifies a telephone number by reach, billing model, network, or dialing format.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `PhoneNumberType.Local` | A number expressed in a local dialing format. | A number expressed in a local dialing format. |
| `PhoneNumberType.TollFree` | A toll-free number for which the recipient generally pays the call charges. | A toll-free number for which the recipient generally pays the call charges. |
| `PhoneNumberType.Mobile` | A number assigned to a mobile or cellular service. | A number assigned to a mobile or cellular service. |
| `PhoneNumberType.National` | A number expressed in a national dialing format. | A number expressed in a national dialing format. |
| `PhoneNumberType.SharedCost` | A shared-cost number whose call charges are divided between caller and recipient. | A shared-cost number whose call charges are divided between caller and recipient. |
| `PhoneNumberType.Landline` | A number assigned to a fixed-line telephone service. | A number assigned to a fixed-line telephone service. |
| `PhoneNumberType.Shortcode` | A short code used for abbreviated dialing or messaging. | A short code used for abbreviated dialing or messaging. |
| `PhoneNumberType.Longcode` | A standard-length number used for voice or messaging. | A standard-length number used for voice or messaging. |
| `PhoneNumberType.Unknown` | The phone-number classification could not be determined. | The phone-number classification could not be determined. |
