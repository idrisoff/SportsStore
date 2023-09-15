var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvc(routes =>
{

});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

//app.MapGet("/", () => "Hello World!");

app.Run();
