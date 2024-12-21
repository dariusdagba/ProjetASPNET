using RestaurantApp1.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace RestaurantApp1.Data
{
    public class RestaurantContext :DbContext 
    {
       
      public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }

      public DbSet<Plat> Plats { get; set; }
    }
}
