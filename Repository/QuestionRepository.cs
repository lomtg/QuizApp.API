using QuizApp.API.Context;
using QuizApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly AppDbContext _context;

        public QuestionRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<Question> AddQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<Question> DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetQuestions(int id)
        {
            throw new NotImplementedException();
        }
    }
}
