using WebApplication1.controllers;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //    builder بكتبها هنا في ال ConfigureServices اي حاجه كانت بتتكتب في 
            //
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            #region MyRegion
            //  app بكتبها هنا في ال Configure اي حاجه كانت بتتكتب في ال
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/home", () => "Hello mora");
            //app.MapGet("/about", () => "Hello mora");
            // ليها هنا routing   لحاجه هروح اعمل   action  شويه هروح اعمل  more dynamic عايزا الموضوع يكون 
            //كده مش هخلص 
            #endregion





            #region MyRegion

            // app.UseRouting();
            //app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello World!");
            //     });


            //     endpoints.MapGet("/home", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello mora");
            //     });
            //     endpoints.MapGet("/product", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello mora");
            //     });

            //     endpoints.MapGet("/product /{id}", async context =>
            //     {
            //         var id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //         await context.Response.WriteAsync($"your product {id}");
            //     });


            //     endpoints.MapGet("/product /{id}/{author}", async context =>
            //     {
            //         var id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //         var author = (context.Request.RouteValues["author"]);
            //         await context.Response.WriteAsync($"your product {id} {author}");
            //     });

            //     endpoints.MapGet("/product /{id?}", async context =>
            //     {
            //         var id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //         await context.Response.WriteAsync($"your product {id}");
            //     }); 


            // });
            #endregion
            app.UseStaticFiles();


            // builder.Services.AddControllers();  مش هتشتغل الا اما اضيفلها ده
            app.MapControllerRoute(
                name: "defalt",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults :new {Controller = "Home" ,Action = "Index" }
                ); 
            app.Run();
        }
    }
}
