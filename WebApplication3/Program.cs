namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<MyMiddleware>();
            var app = builder.Build();

            //      app.MapGet("/", () => "Hello World!");

   /*         app.Use(async (context, next) =>
            {
                Console.WriteLine("Before Request in Use");
                await next();
                Console.WriteLine("After Request in Use");
            });
*/
          
            app.UseWhen(context => context.Request.Path.Equals("/auth"), handler);
            app.UseMiddleware<MyMiddleware>();
            app.Run(async (context) =>
            {
                Console.WriteLine("Before Request in Run");
                await context.Response.WriteAsync("Hello World!");
                Console.WriteLine("After Request in Run");
            });


            app.Run();



        }

        private static void handler(IApplicationBuilder app)
        {
            app.Use(async (context,next) =>
            {
                
                Console.WriteLine("Before Request in Run Another");
                await context.Response.WriteAsync("Hello World! from Mapping");
                await next(context);
                Console.WriteLine("After Request in Run Another");
            });

        }

    }
}