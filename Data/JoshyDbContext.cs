using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joshy_api.Models;
using Microsoft.EntityFrameworkCore;
namespace Joshy_api.Data
{
    public class JoshyDbContext:DbContext
    {
        public JoshyDbContext(DbContextOptions<JoshyDbContext> options) : base(options)
        {

        }
        public DbSet<User> User{get; set;}
        public DbSet<Order> Order{get; set;}
        public DbSet<OrderDetails> OrderDetails{get; set;}
        public DbSet<Products> Products{get; set;}

    }
}