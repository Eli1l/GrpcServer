using GrpcSE1Server.Models;
using LinqToDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcSE1Server.Data
{
    public class DataContex : DbContex
    {
        public DataContex(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Catrgories { get; set; }
        public DbSet<GameProduct> Products { get; set; }
    }
}
