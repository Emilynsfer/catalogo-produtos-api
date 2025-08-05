using CatalogoProdutosMinimalAPI.Data;
using CatalogoProdutosMinimalAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Banco de dados SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=products.db"));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Endpoints CRUD

// Listar todos os produtos
app.MapGet("/products", async (AppDbContext db) =>
    await db.Products.ToListAsync());

// Obter um produto por ID
app.MapGet("/products/{id}", async (int id, AppDbContext db) =>
    await db.Products.FindAsync(id)
        is Product product
            ? Results.Ok(product)
            : Results.NotFound());

// Criar produto
app.MapPost("/products", async (Product product, AppDbContext db) =>
{
    db.Products.Add(product);
    await db.SaveChangesAsync();
    return Results.Created($"/products/{product.Id}", product);
});

// Atualizar produto
app.MapPut("/products/{id}", async (int id, Product inputProduct, AppDbContext db) =>
{
    var product = await db.Products.FindAsync(id);
    if (product is null) return Results.NotFound();

    product.Name = inputProduct.Name;
    product.Description = inputProduct.Description;
    product.Price = inputProduct.Price;
    product.Stock = inputProduct.Stock;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

// Deletar produto
app.MapDelete("/products/{id}", async (int id, AppDbContext db) =>
{
    var product = await db.Products.FindAsync(id);
    if (product is null) return Results.NotFound();

    db.Products.Remove(product);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();
