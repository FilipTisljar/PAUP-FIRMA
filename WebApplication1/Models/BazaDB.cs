using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BazaDB : DbContext
    {
        public DbSet<BazaDB> Baza { get; set; }
    }
}