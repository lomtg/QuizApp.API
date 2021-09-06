using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.API.Models
{
    public class Question 
    {
        [Key]
        public int Id { get; set; }
        public int QuizId { get; set; }
        public String Description { get; set; }
        public String CorrectAnwser { get; set; }
        public String WrongAnwser { get; set; }

    }
}
