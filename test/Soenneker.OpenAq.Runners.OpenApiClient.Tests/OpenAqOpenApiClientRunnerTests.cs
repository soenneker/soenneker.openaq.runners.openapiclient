using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenAq.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenAqOpenApiClientRunnerTests : HostedUnitTest
{
    public OpenAqOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
