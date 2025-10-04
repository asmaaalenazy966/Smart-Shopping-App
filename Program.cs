using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// NOTE: This is a simplified mock API for demo purposes.
// Replace in production with proper authentication, validation, and database access.

var products = new List<object>{
    new { id=1, name="Milk 1L", price=5.0 },
    new { id=2, name="Bread", price=2.5 },
    new { id=3, name="Eggs (6)", price=3.0 }
};

app.MapGet("/", () => Results.Json(new { message = "SmartShopping API running" }));

app.MapGet("/api/products", () => Results.Json(products));

app.MapPost("/api/cart/add", async (HttpRequest req) =>
{
    var doc = await JsonDocument.ParseAsync(req.Body);
    return Results.Json(new { ok = true, detail = "Item added (demo)" });
});

app.MapPost("/api/sensor/event", async (HttpRequest req) =>
{
    var doc = await JsonDocument.ParseAsync(req.Body);
    return Results.Json(new { ok = true, received = doc.RootElement.ToString() });
});

app.Run();
