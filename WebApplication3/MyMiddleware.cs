namespace WebApplication3
{
    public class MyMiddleware : IMiddleware
    {
        public async  Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Before Request in Use");
            await next(context);
            Console.WriteLine("After Request in Use");
        }
    }




}
