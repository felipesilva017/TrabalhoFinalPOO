using API_Adocao_Animais.Domain.Interfaces;
using API_Adocao_Animais.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura��o dos servi�os
builder.Services.AddScoped<IAdocaoService, AdocaoService>();

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
