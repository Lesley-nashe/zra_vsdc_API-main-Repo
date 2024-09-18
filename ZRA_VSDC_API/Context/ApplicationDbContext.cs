using System;
using Microsoft.EntityFrameworkCore;
using ZRA_VSDC_API.Models;

namespace ZRA_VSDC_API.Context;

public class ApplicationDbContext : DbContext
{
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

     public DbSet<Sale> Sales { get; set; }
    
}
