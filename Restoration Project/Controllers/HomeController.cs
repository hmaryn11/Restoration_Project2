using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restoration_Project.DAL;
using Restoration_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Controllers
{
    public class HomeController : Controller
    {
        private JosephJeopardyContext _jjcontext { get; set; }
        private IRestorationRepo repo { get; set; }

        public HomeController(JosephJeopardyContext temp, IRestorationRepo blah)
        {
            _jjcontext = temp;
            repo = blah;
        }

        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult JeopardyHome()
        {
            return View();
        }


        public IActionResult Dashboard()
        {
            ViewBag.Topics = _jjcontext.Topic;

            List<Question> ques = _jjcontext.Question.ToList();

            ViewBag.Questions = ques;

            bool gameComp = true;
            
            foreach (var q in ques)
            {
                if (!q.Viewed) //this is a shorthand way of saying == false
                {
                    gameComp = false;
                    break;
                }
            }

            if (!gameComp)
            {
                return View();
            }
            else
            {
                return RedirectToAction("GameCompleted");
            }

        }

        public IActionResult GameCompleted()
        {
            return View();
        }

        public IActionResult ResetGame()
        {
            repo.ClearAllViewed();

            return RedirectToAction("Dashboard");
        }

        public IActionResult QuesPage(IFormCollection form)
        {
            //int questionid = Convert.ToInt32(form["QuestionId"].ToString());

            int questionid = repo.GetQuestionIdFromPage(form);

            Question ques = _jjcontext.Question.Where(q => q.QuestionId == questionid).First(); //grabbing the specific 

            ViewBag.Question = ques; //this is how you access only the question you want

            ViewBag.Topic = _jjcontext.Topic.Where(t => t.TopicId == ques.TopicId).First();

            ViewBag.Answers = _jjcontext.Answer.Where(a => a.QuestionId == questionid).ToList(); //this grabs a list of all the answers that correlate with the qid

            ques.Viewed = true; //once you get to this page, change the question.viewed for this particular question from false to true

            _jjcontext.SaveChanges(); //save the changes in the viewed field

            return View();
        }
        public IActionResult ShowDetails(IFormCollection form)
        {
            int questionid = repo.GetQuestionIdFromPage(form);

            Question ques = _jjcontext.Question.Where(q => q.QuestionId == questionid).First();

            ViewBag.Question = ques; //this is how you access only the question you want

            ViewBag.Topic = _jjcontext.Topic.Where(t => t.TopicId == ques.TopicId).First();

            return View();

        }
       
        public IActionResult PointValueKey()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }

    }
}
