using System;
using System.Globalization;

namespace Soenneker.Culture.English.US;

/// <summary>
/// A cache of CultureInfo.GetCultureInfo for en-US.
/// </summary>
public static class CultureEnUsCache
{
    private static readonly Lazy<CultureInfo> _cultureInfoLazy = new(() => CultureInfo.GetCultureInfo("en-US"));

    public static CultureInfo CultureInfo = _cultureInfoLazy.Value;
}
