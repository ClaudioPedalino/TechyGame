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

        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionsXQuestion> OptionsXQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserXGame> UsersXGame { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
