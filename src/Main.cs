using Middleware;
using Resolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDbContext<PgDbContext>()
    .AddGraphQLServer()
    .AddQueries()
    .AddMutations();

var app = builder.Build();

app.UseRouting();

app.ServeStaticAssets();
app.ServeGraphiQLPlayground();

app.MapGraphQL();

app.Run("http://localhost:7890");