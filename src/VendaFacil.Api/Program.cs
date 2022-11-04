using System.Text.Json.Serialization;
using VendaFacil.Api;
using VendaFacil.CrossCutting.Ioc;
using VendaFacil.Infra.Database;
using VendaFacil.Service.AutoMapper;
using VendaFacil.Service.Middleware;

DotEnvLoad.Load();

#region [Propriedades Privadas]
string pastaFront = Environment.GetEnvironmentVariable("PASTA_FRONT") ?? "";
string urlFront = Environment.GetEnvironmentVariable("URL_FRONT") ?? "";
#endregion

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = $"../VendaFacil.UI/dist");
builder.Services.AddControllers()
    .AddJsonOptions(x => { x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull; })
    .AddNewtonsoftJson(x => { x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

new DatabaseConfiguration().GerenciarBanco();
NativeInjector.RegisterServices(builder.Services);

var app = builder.Build();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyMethod());
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
app.UseStaticFiles();
app.UseSpaStaticFiles();
app.UseMiddleware(typeof(ErrorMiddleware));
app.UseSpa(x =>
{
    x.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), pastaFront);

    //if(app.Environment.IsDevelopment())
    //    x.UseProxyToSpaDevelopmentServer(urlFront);
});
app.Run();
