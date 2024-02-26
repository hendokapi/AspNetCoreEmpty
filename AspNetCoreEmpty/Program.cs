var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


// /User

// /User/Show/100


//app.MapGet("/", (HttpContext context) =>
//{
//    context.Response.ContentType = "text/html";
//    return @"
//        <!DOCTYPE html>
//        <html lang=""en"">
//        <head>
//            <meta charset=""UTF-8"">
//            <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
//            <title>Document</title>
//        </head>
//        <body>
//            <h1>Hello World!</h1>
//            <form action=""/manageform"" method=""get"">
//                <input type=""text"" name=""name"">
//                <input type=""text"" name=""lastname"">
//                <input type=""text"" name=""age"">
//                <button>Sumbit</button>
//            </form>
//        </body>
//        </html>";
//});


app.Run();
