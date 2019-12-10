using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeckyGame.Models
{
    public class TeckyDBContext : DbContext
    {
        public TeckyDBContext(DbContextOptions<TeckyDBContext> options) : base(options)
        {

        }

        public DbSet<GameType> GameType { get; set; }
    }
}
