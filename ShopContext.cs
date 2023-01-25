using ProjZal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjZal
{
    public class ShopContext : DbContext
    {
        public DbSet<ShopModel> Shops { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



            dbContextOptions.UseSqlServer(cs);
        }
    }
}