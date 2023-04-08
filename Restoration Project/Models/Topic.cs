using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restoration_Project.Models
{
    public class Topic
    {
        [Key]
        [Required]
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string BGColor { get; set; } //for pop-up/div background color
        public string DivColor { get; set; } //for smaller div color
    }
}


//TopicId
//TopicName
//BGColor
//DivColor