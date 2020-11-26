using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamaapp.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime CreatedDate { get; set; }
        public Question Question { get; set; }

    }
}
