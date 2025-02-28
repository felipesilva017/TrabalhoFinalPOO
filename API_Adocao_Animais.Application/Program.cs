using API_Adocao_Animais.Domain.Interfaces;
using API_Adocao_Animais.Application.Services;
using API_Adocao_Animais.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura��o dos servi�os
builder.Services.AddScoped<IAdocaoService, AdocaoService>();
builder.Services.AddScoped<IAdocaoRepository, AdocaoRepository>();

builder.Services.AddControllers();

// Adicionando servi�os para Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura��o do pipeline de requisi��o
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configura��o das rotas
app.UseRouting();

app.MapControllers();

app.Run();
