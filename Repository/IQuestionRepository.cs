using QuizApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Repository
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<Question>> GetQuestions(int id);
        Task<Question> AddQuestion(Question question);
        Task<Question> DeleteQuestion(int id);
    }
}
