using API_Adocao_Animais.Domain.Interfaces;
using API_Adocao_Animais.Application.Services;
using API_Adocao_Animais.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddScoped<IAdocaoService, AdocaoService>();
builder.Services.AddScoped<IAdocaoRepository, AdocaoRepository>();

builder.Services.AddControllers();

// Adicionando serviços para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do pipeline de requisição
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configuração das rotas
app.UseRouting();

app.MapControllers();

app.Run();
