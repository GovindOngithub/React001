var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ReactApp2_Server>("reactapp2-server");

builder.Build().Run();
