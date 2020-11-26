using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamaapp.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PassMark { get; set; }
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }


    }
}
