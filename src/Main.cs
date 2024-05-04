using Cfg;
using HotChocolate.Types.Descriptors;
using Resolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQuery>()
    .AddConvention<INamingConventions>(new PreserveMethodNamesNamingConvention());

var app = builder.Build();

app.MapGraphQL();

app.Run();




