using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Models.ViewModels
{
    public class QuestionsViewModel
    {
        public Question Question { get; set; }
        public Answer Answer { get; set; }
        public Topic Topic { get; set; }
    }
}
