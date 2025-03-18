namespace IntegrationTests;

[Collection(nameof(IntegratedTests))]
public class IntegrationTest3
{
    [Fact]
    public async Task GetWebResourceRootReturnsOkStatusCode()
    {
        await Test.RunAsync();
    }
}
