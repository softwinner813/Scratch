var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Use MVC
services.AddMvc();



var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


// App Routing
app.UseRouting();
app.UseEndpoints(endpoints =>
{ 
    endpoints.MapDefaultControllerRoute(); 
});

//app.MapGet("/", () => "Hello World!");

app.Run();
