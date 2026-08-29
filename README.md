[![](https://img.shields.io/nuget/v/soenneker.culture.english.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.culture.english.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.culture.english.us/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.culture.english.us/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.culture.english.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.culture.english.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.culture.english.us/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.culture.english.us/actions/workflows/codeql.yml)

# Soenneker.Culture.English.US

A cache of CultureInfo.GetCultureInfo for en-US.

## Install

```bash
dotnet add package Soenneker.Culture.English.US
```

## What you get

- `CultureEnUsCache` — A cache of CultureInfo.GetCultureInfo for en-US.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `CultureEnUsCache.Instance` | The cached `CultureInfo` instance for "en-US" (English - United States). | The cached `CultureInfo` instance for "en-US" (English - United States). |

## Practical notes

- Calls that return a cached or singleton value reuse the same instance until the owning service is disposed.
