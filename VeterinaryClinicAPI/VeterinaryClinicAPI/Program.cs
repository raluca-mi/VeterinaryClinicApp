using VeterinaryClinicAPI.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
Dependencies.Inject(builder);

var app = builder.Build();

app.UseSwagger(c =>
{
    c.RouteTemplate = "api/swagger/{documentName}/swagger.json";
});
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/api/swagger/v1/swagger.json", "VeterinaryClinicApp");
    c.RoutePrefix = "api/swagger";
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


/////////////////////////////////
///TEST CODE
////////////////////////////////
///////////////////////////////
///TEST CODE 2
///////////////////////////////