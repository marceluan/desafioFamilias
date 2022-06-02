using DT.SelecaoFamilias.AppService;
using DT.SelecaoFamilias.AppService.Interfaces;
using DT.SelecaoFamilias.Domain.Interfaces;
using DT.SelecaoFamilias.Domain.Services;
using DT.SelecaoFamilias.Infra.Data.Interfaces;
using DT.SelecaoFamilias.Infra.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IListarFamiliasOrdenadasPorPontosAppService, ListarFamiliasOrdenadasPorPontosAppService>();
builder.Services.AddTransient<IFamiliaService, FamiliaService>();
builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
