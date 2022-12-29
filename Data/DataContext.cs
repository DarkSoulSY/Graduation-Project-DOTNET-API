using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness_Application.Models;

namespace Fitness_Application.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Preferences> Preferences => Set<Preferences>();
        public DbSet<Diary> Diaries => Set<Diary>();
        public DbSet<FoodProduct> FoodProducts => Set<FoodProduct>();
    }
}