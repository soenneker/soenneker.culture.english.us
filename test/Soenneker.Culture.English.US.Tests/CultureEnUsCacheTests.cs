using Soenneker.Culture.English.US.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Culture.English.US.Tests;

[Collection("Collection")]
public class CultureEnUsCacheTests : FixturedUnitTest
{
    private readonly ICultureEnUsCache _util;

    public CultureEnUsCacheTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ICultureEnUsCache>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
