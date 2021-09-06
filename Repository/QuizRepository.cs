using Microsoft.EntityFrameworkCore;
using QuizApp.API.Context;
using QuizApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Repository
{
    public class QuizRepository : IQuizRepository
    {

        private readonly AppDbContext _context;

        public QuizRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Quiz> GetQuiz(int id)
        {
            return await _context.Quizs.FindAsync(id);
        }

        public async Task<IEnumerable<Quiz>> GetQuizs()
        {
            return await _context.Quizs.ToListAsync();
        }
    }
}
