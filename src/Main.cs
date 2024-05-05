using Middleware;
using Resolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQuery>();

var app = builder.Build();

app.UseRouting();

app.UseGraphiQLMiddleware(System.IO.Path.Combine("src/assets", "graphiql.html"));

app.MapGraphQL();

app.Run();