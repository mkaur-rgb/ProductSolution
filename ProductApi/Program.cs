using ProductApi.Domain;
using ProductApi.Infrastructure;
//CRUD MINIMAL API (Using dummy data )
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendOnly", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddSingleton<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowFrontendOnly");

//GET All Products
app.MapGet("/api/products", async (IProductRepository repo) =>
    Results.Ok(await repo.GetAllAsync())
);

// GET Productbyid
app.MapGet("/api/products/{id:int}", async (int id, IProductRepository repo) =>
{
    var product = await repo.GetByIdAsync(id);
    return product is not null ? Results.Ok(product) : Results.NotFound();
});

// POST add product
app.MapPost("/api/products", async (Product product, IProductRepository repo) =>
{
    await repo.AddAsync(product);
    return Results.Created($"/api/products/{product.Id}", product);
});

// PUT update product
app.MapPut("/api/products/{id:int}", async (int id, Product updatedProduct, IProductRepository repo) =>
{
    if (id != updatedProduct.Id) return Results.BadRequest();
    await repo.UpdateAsync(updatedProduct);
    return Results.NoContent();
});

// DELETE product
app.MapDelete("/api/products/{id:int}", async (int id, IProductRepository repo) =>
{
    await repo.DeleteAsync(id);
    return Results.NoContent();
});

app.Run();
