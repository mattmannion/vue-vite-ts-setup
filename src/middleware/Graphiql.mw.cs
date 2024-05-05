namespace Middleware;

public class GraphiQLMiddleware {
  private readonly RequestDelegate _next;
  private readonly string _indexPath;

  public GraphiQLMiddleware(RequestDelegate next, string indexPath) {
    _next = next;
    _indexPath = indexPath;
  }

  public async Task InvokeAsync(HttpContext context) {
    if (
      context.Request.Path.StartsWithSegments("/graphql")
      && context.Request.Method == "GET"
    ) {
      context.Response.ContentType = "text/html";
      await context.Response.WriteAsync(File.ReadAllText(_indexPath));
    } else await _next(context);
  }
}

public static class GraphiQLMiddlewareExtensions {
  public static IApplicationBuilder ServeGraphiQLPlayground(
    this IApplicationBuilder builder
  ) {
    return builder.UseMiddleware<GraphiQLMiddleware>(
      System.IO.Path.Combine("src/assets", "graphiql.html")
    );
  }
}