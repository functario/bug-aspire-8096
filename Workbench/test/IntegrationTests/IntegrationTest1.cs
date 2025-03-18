namespace IntegrationTests;

[Collection(nameof(IntegratedTests))]
public class IntegrationTest1
{
    [Fact]
    public async Task GetWebResourceRootReturnsOkStatusCode()
    {
        await Test.RunAsync();
    }
}
