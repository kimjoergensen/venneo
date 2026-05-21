var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Venneo_Identity_API>("venneo-identity-api");

builder.Build().Run();
