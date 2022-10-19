// See https://aka.ms/new-console-template for more information
using InstaBuy.Application.Handlers.Request;
using InstaBuy.Domain.Handlers.Request;
using InstaBuy.Worker;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Reflection;

var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();

var builder = Host.CreateDefaultBuilder(args).UseSerilog(logger);

builder.ConfigureServices(
    services =>
        services.AddHostedService<Principal>()
    .AddMediatR(Assembly.GetExecutingAssembly())
    .AddMediatR(typeof(FilaRequest).GetTypeInfo().Assembly)
    .AddMediatR(typeof(GetProdutosRequest).GetTypeInfo().Assembly)
);

var host = builder.Build();

host.Run();

