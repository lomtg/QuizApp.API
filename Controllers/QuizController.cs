using Microsoft.AspNetCore.Mvc;
using QuizApp.API.Models;
using QuizApp.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _quizRepository;

        private readonly IQuestionRepository _questionRepository;

        public QuizController(IQuizRepository quizRepository, IQuestionRepository questionRepository)
        {
            _quizRepository = quizRepository;
            _questionRepository = questionRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Quiz>> GetQuizs()
        {
            return await _quizRepository.GetQuizs();
        }

        [HttpGet("id")]
        public async Task<Quiz> GetQuiz(int id)
        {
            return await _quizRepository.GetQuiz(id);
        }
        
    }
}
