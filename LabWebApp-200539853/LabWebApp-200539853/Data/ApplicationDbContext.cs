using System;
using System.Runtime.ConstrainedExecution;
using LabWebApp_200539853.Models;
using Microsoft.EntityFrameworkCore;

namespace LabWebApp_200539853.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

