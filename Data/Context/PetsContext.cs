using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMysql2.Data.Models;

namespace TestMysql2.Data.Context
{
    public class PetsContext :DbContext
    {
    public PetsContext(DbContextOptions<PetsContext> options) : base(options)
    {

    }

    public PetsContext()
    {

    }

      public DbSet<Dog> Dogs { get; set; }
    }
}
