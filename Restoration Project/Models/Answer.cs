using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Models
{
    public class Answer
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string FullAnswer { get; set; } 
        public bool Corr_Wrong { get; set; }
        public int AnswerNum { get; set; } //1-4 if correct=1 if wrong=2-4 (do this to be able to do random function for displaying on QuesPage)
    }
}


//AnswerId
//QuestionId
//FullAnswer
//Corr_Wrong
//AnswerNum