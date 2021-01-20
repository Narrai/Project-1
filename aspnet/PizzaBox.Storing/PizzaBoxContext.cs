using System;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options) : base(options) { }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Customer> Customers {get;set;}

    public DbSet<APizzaModel> Pizzas { get; set; }

    public DbSet<Crusts> Cursts { get; set; }

    public DbSet<Sizes> Sizes {get; set;}

    public DbSet<Toppings> Toppings { get; set; }

    public DbSet<Prices> Prices { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Order>().HasKey(o => o.EntityId);
      builder.Entity<Store>().HasKey(s => s.EntityId);
      builder.Entity<Customer>().HasKey(c => c.EntityId);
      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
      builder.Entity<Crusts>().HasKey(c => c.EntityId);
      builder.Entity<Sizes>().HasKey(si => si.EntityId);
      builder.Entity<Prices>().HasKey(p => p.EntityId);
      builder.Entity<Toppings>().HasKey(t => t.EntityId);


      builder.Entity<Store>().HasData(
        new Store() { EntityId = 1, Name = "Dominos" },
        new Store() { EntityId = 2, Name = "Pizz Hut" },
        new Store() { EntityId = 3, Name = "Papa John's" }
      );

      builder.Entity<Order>().HasData(
        new Order{
          EntityId = 1,
          StoreEntityId = 1,
          DateModified = DateTime.Now,
          TotalPrice = 20.45f
        },
        new Order{
          EntityId = 2,
          StoreEntityId = 1,
          DateModified = DateTime.Now,
          TotalPrice = 33.45f
        }
      );

      builder.Entity<Customer>().HasData(
        new Customer{
          EntityId=1,
          Name = "Nar",
          StoreEntityId = 1
        }
      );

      builder.Entity<Toppings>().HasData(
                new Toppings{EntityId=1, Name = "tomato"},
                new Toppings{EntityId=2, Name = "grilled chicken"},
                new Toppings{EntityId=3, Name = "sauce"},
                new Toppings{EntityId=4, Name = "jalapenos"},
                new Toppings{EntityId=5, Name = "ham"},
                new Toppings{EntityId=6, Name = "sauce"}
            );
      builder.Entity<Crusts>().HasData(
                  new Crusts{EntityId=1, Name = "thick"},
                  new Crusts{EntityId=2, Name = "thin"},
                  new Crusts{EntityId=3, Name = "stuffed"}
              );

        builder.Entity<Sizes>().HasData(
                  new Sizes{EntityId=1, Size="small"},
                  new Sizes{EntityId=2, Size="medium"},
                  new Sizes{EntityId=3, Size="large"}
              );

            builder.Entity<Prices>().HasData(
                new Prices{EntityId=1, Price=10.99f, SizeEntityId = 1},
                new Prices{EntityId=2, Price=12.99f, SizeEntityId = 2},
                new Prices{EntityId=3, Price=14.99f, SizeEntityId = 3}
            );

          builder.Entity<Pizza>().HasData(
                new Pizza{
                    EntityId = 1,
                    Crust="stuffed",
                    Size = "small",
                    Price = 10.99f
                },
                new Pizza{
                    EntityId = 2,
                    Crust="thick",
                    Size = "medium",
                    Price = 12.99f
                }
            );
    }
  }
}