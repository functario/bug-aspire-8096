namespace IntegrationTests;

public static class Test
{
    private static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(30);

    public static async Task RunAsync()
    {
        var appHost = await DistributedApplicationTestingBuilder.CreateAsync<Projects.AppHost>(
            TestContext.Current.CancellationToken
        );

        await using var app = await appHost
            .BuildAsync(TestContext.Current.CancellationToken)
            .WaitAsync(DefaultTimeout, TestContext.Current.CancellationToken);

        await app.StartAsync(TestContext.Current.CancellationToken)
            .WaitAsync(DefaultTimeout, TestContext.Current.CancellationToken);

        //app.GetConnectionStringAsync("");

        await app.StopAsync(TestContext.Current.CancellationToken);
    }
}
