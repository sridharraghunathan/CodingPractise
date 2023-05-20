using Microsoft.AspNetCore.Http;

namespace WebApplication1
{

 
public class MyMiddleware : IMiddleware
    {
 
        private readonly ILogger _logger;

        public MyMiddleware( ILoggerFactory logFactory)
        {
 
            _logger = logFactory.CreateLogger("MyMiddleware");
        }
 

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogInformation("MyMiddleware executing..");

            await next(context); // calling next middleware
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}
