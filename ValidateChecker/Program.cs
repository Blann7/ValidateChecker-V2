using ValidateChecker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();


// Scaffold-DbContext "Server=31.31.196.234;Database=u1690754_bp;User Id=u1690754_admin;Password=LenaGolovach777" Microsoft.EntityFrameworkCore.SqlServer