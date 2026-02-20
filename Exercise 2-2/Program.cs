var builder = WebApplication.CreateBuilder(args);

// Le decimos que use Controladores y Vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Le damos permiso para leer la carpeta wwwroot y crear las rutas
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();