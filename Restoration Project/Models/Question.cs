using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Models
{
    public class Question
    {
        [Key]
        [Required]
        public int QuestionId { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public string FullQuestion { get; set; }
        public int PointValue { get; set; }
        // public image PicClip {get;set;}
        public string Explanation { get; set; }
        public bool Viewed { get; set; }
    }
}

//QuestionId
//TopicId
//FullQuestion
//PointValue
//Explanation
//Viewed
