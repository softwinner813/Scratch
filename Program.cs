using Scratch.Models;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddDbContext<InventoryContext>();

// Use MVC
services.AddMvc();



var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();       

//app.UseAuthentication();    
// App Routing
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    //endpoints.MapDefaultControllerRoute(); 
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Products}/{action=Index}/{id?}");
});

//app.MapGet("/", () => "Hello World!");

app.Run();
