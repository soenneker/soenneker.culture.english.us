[![](https://img.shields.io/nuget/v/soenneker.culture.english.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.culture.english.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.culture.english.us/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.culture.english.us/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.culture.english.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.culture.english.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.culture.english.us/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.culture.english.us/actions/workflows/codeql.yml)

# Soenneker.Culture.English.US

Shared access to the read-only `en-US` `CultureInfo` returned by `CultureInfo.GetCultureInfo`.

## Installation

```bash
dotnet add package Soenneker.Culture.English.US
```

## Formatting

```csharp
using Soenneker.Culture.English.US;

CultureInfo culture = CultureEnUsCache.Instance;

string amount = 1234.56m.ToString("C", culture);
// $1,234.56

string date = new DateTime(2026, 8, 29).ToString("d", culture);
// 8/29/2026
```

## Parsing

```csharp
decimal amount = decimal.Parse(
    "1,234.56",
    NumberStyles.Number,
    CultureEnUsCache.Instance);

DateTime date = DateTime.Parse(
    "8/29/2026",
    CultureEnUsCache.Instance);
```

`CultureEnUsCache.Instance` is the same cached instance returned by `CultureInfo.GetCultureInfo("en-US")`. It is thread-safe for formatting and parsing and is read-only; attempts to change its number or date settings throw `InvalidOperationException`.

When custom settings are required, clone it before modifying:

```csharp
var custom = (CultureInfo)CultureEnUsCache.Instance.Clone();
custom.NumberFormat.CurrencySymbol = "USD ";
```

Accessing this value does not change `CurrentCulture`, `CurrentUICulture`, or application localization settings. No dependency-injection registration or disposal is required.
