using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<StoreContext>() ?? throw new InvalidOperationException("Failed to retrieve Store Data");

        SeedData(context);
    }

    private static void SeedData(StoreContext context)
    {
        context.Database.Migrate();
        if (context.Products.Any()) return;
        var products = new List<Product>
        {
            new() {
                Name = "Angular Speedster Board 2000",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere",
                Price = 20000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "Green Angular Board 3000",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 15000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "Core Board Speed Rush 3",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenat",
                Price = 18000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "Net Core Super Board",
                Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy",
                Price = 30000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "React Board Super Whizzy Fast",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed",
                Price = 25000,
                PictureUrl ="/images/products/cat.jpg",
                Brand = "React",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "Typescript Entry Board",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna",
                Price = 12000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "TypeScript",
                Type = "Boards",
                QuantityInStock = 100
            },
            new() {
                Name = "Core Blue Hat",
                Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "NetCore",
                Type = "Hats",
                QuantityInStock = 100
            },
            new() {
                Name = "Green React Woolen Hat",
                Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 8000,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new() {
                Name = "Purple React Woolen Hat",
                Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new() {
                Name = "Green React Gloves",
                Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1400,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new() {
                Name = "Redis Red Boots",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25000,
                PictureUrl ="/images/products/cat.jpg",
                Brand = "Redis",
                Type = "Boots",
                QuantityInStock = 100
            },
            new() {
                Name = "Core Red Boots",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies",
                Price = 18999,
                PictureUrl ="/images/products/cat.jpg",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new() {
                Name = "Core Purple Boots",
                Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauri",
                Price = 19999,
                PictureUrl = "/images/products/cat.jpg",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new() {
                Name = "Angular Purple Boots",
                Description = "Aenean nec lorem. In porttitor. Donec coreet nonummy augue.",
                Price = 15000,
                PictureUrl ="/images/products/cat.jpg",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            },
            new() {
                Name = "Angular Blue Boots",
                Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend",
                Price = 18000,
                PictureUrl ="/images/products/cat.jpg",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            }
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}
