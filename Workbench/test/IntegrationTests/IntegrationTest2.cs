namespace IntegrationTests;

[Collection(nameof(IntegratedTests))]
public class IntegrationTest2
{
    [Fact]
    public async Task GetWebResourceRootReturnsOkStatusCode()
    {
        await Test.RunAsync();
    }
}
