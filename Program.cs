using CatalogoDemoApp;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProdutosService, ProdutosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/api/produtos/{ean}", ([FromServices] IProdutosService produtosService, string ean) =>
{
    var resultado = produtosService.ObterProduto(ean);

    if (resultado != null)
    {
        return Results.Ok(resultado);
    }
    return Results.NotFound(new
    {
        Error = "Produto não localizado no banco de imagens"
    });
})
.WithName("ObterProdutos")
.WithOpenApi();

app.Run();

