using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApp.API.Models;

namespace QuizApp.API.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
