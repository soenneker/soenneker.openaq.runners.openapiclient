using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenAq.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenAqOpenApiClientRunnerTests : FixturedUnitTest
{
    public OpenAqOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
