using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamaapp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string Description { get; set; }
        public bool HasMoreThanOneAnswer { get; set; }
        public DateTime createdDate { get; set; }
        public Exam Exam { get; set; }

    }
}
