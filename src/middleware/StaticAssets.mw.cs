using Microsoft.Extensions.FileProviders;

public static class StaticAssetsExtention {
  public static IApplicationBuilder ServeStaticAssets(this IApplicationBuilder app) {
    return app.UseStaticFiles(new StaticFileOptions {
      FileProvider = new PhysicalFileProvider(
        System.IO.Path.Combine(Directory.GetCurrentDirectory(), "src/assets")
      ),
      RequestPath = new PathString("/assets")
    });
  }
}