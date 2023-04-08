using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.DAL
{
    public interface IRestorationRepo
    {
        public int GetQuestionIdFromPage(IFormCollection form);
        public void ClearAllViewed();
    }
}
