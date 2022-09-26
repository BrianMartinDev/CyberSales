using System;
using Microsoft.EntityFrameworkCore;
using CyberSales.Models;

namespace CyberSales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}

