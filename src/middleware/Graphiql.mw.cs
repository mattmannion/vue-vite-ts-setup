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
  public static IApplicationBuilder UseGraphiQLMiddleware(
    this IApplicationBuilder builder,
    string indexPath
    ) {
    return builder.UseMiddleware<GraphiQLMiddleware>(indexPath);
  }
}