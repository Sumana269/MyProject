using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "ChocklateCake", Description = "Freshly baked Choclate cake", Price = 45.98f, ImageName = "cake.png" },
                new Product { Id = 2, Name = "CoolCake", Description = "Lot Of Flavours Are Available", Price = 98.45f, ImageName = "coolcake.png" },
                new Product { Id = 3, Name = "Puffs", Description = "Varieties Of Puffs are Available", Price = 87.9f, ImageName = "puffs.png" }
                );
            return builder;
        }
    }
}
