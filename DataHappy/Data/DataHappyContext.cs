using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataHappy.Models;

namespace DataHappy.Data
{
    public class DataHappyContext : DbContext
    {
        public DataHappyContext (DbContextOptions<DataHappyContext> options)
            : base(options)
        {
        }

        public DbSet<DataHappy.Models.Conference> Conference { get; set; }
    }
}
