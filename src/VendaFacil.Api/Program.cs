using VendaFacil.Api;
using VendaFacil.CrossCutting.Ioc;
using VendaFacil.Infra.Database;
using VendaFacil.Service.AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

DotEnvLoad.Load();
DatabaseConfiguration.GerenciarBanco();
NativeInjector.RegisterServices(builder.Services);

var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
