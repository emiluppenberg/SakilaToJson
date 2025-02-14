using Microsoft.EntityFrameworkCore;
using SakilaToJson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaToJson
{
    internal class SakilaDbContext : DbContext
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sakila;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Customer> customer { get; set; } = default!;
        public DbSet<Film> film { get; set; } = default!;
        public DbSet<Inventory> inventory { get; set; } = default!;
        public DbSet<Payment> payment { get; set; } = default!;
        public DbSet<Rental> rental { get; set; } = default!;
    }
}
