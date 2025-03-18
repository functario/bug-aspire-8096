var builder = DistributedApplication.CreateBuilder(args);

var dbName = "mydb";
var saPassword = "saPassword123!";
var sqlPassword = builder.AddParameter("sql-password", saPassword, secret: true);

var sqlServer = builder
    .AddSqlServer("sql", port: 51921, password: sqlPassword)
    .WithLifetime(ContainerLifetime.Session);

var sqldb = sqlServer.AddDatabase(dbName);

builder
    .AddProject<Projects.WebApp>("webapp")
    .WithEndpoint("https", endpoint => endpoint.IsProxied = false)
    .WithEndpoint("http", endpoint => endpoint.IsProxied = false)
    .WithReference(sqldb)
    .WaitFor(sqldb);

builder.Build().Run();
