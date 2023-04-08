using Microsoft.AspNetCore.Http;
using Restoration_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.DAL
{
    public class RestorationRepo :IRestorationRepo
    {
        private JosephJeopardyContext _jjcontext { get; set; }
        public RestorationRepo (JosephJeopardyContext temp)
        {
            _jjcontext = temp;
        }

        public int GetQuestionIdFromPage(IFormCollection form)
        {
            int questionid = Convert.ToInt32(form["QuestionId"].ToString());
            return (questionid);
        }

        public void ClearAllViewed()
        {
            var question = _jjcontext.Question;
            foreach (var ques in question)
            {
                ques.Viewed = false;

                _jjcontext.SaveChanges();
            }
        }
 
    }
}
