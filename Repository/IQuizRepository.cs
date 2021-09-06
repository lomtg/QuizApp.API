using QuizApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Repository
{
    public interface IQuizRepository
    {
        Task<IEnumerable<Quiz>> GetQuizs();
        Task<Quiz> GetQuiz(int id);
    }
}
