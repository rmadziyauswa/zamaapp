using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zamaapp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ZamaDbContext context)
        {
            context.Database.EnsureCreated();

            if(context.Users.Any()) // the database has data already so no seeding
            {
                return;
            }

            List<User> users = new List<User>() {
                new User{ Email = "test@test.com", Firstname = "Test", Lastname = "TestLastname", Password = "test123"}
            };

            var exams = new List<Exam> {
                new Exam {CreatedDate = DateTime.Now, Description = "Algos Exam", Name = "Exam Algo", PassMark = 75, User = users[0]}
            };

            var questions = new List<Question>
            {
                new Question{ createdDate = DateTime.Now, Description = "Who is the current American President?", HasMoreThanOneAnswer= false, Exam = exams[0]}
            };

            var answers = new List<Answer> { 
                new Answer{ CreatedDate= DateTime.Now, Description = "Donald J. Trump", IsCorrect = false, Question = questions[0]},
                new Answer{ CreatedDate= DateTime.Now, Description = "Ronald Reagan", IsCorrect = false, Question = questions[0]},
                new Answer{ CreatedDate= DateTime.Now, Description = "Joe Biden", IsCorrect = true, Question = questions[0]},
                new Answer{ CreatedDate= DateTime.Now, Description = "Barack Obama", IsCorrect = false, Question = questions[0]}
            };

            try
            {
                context.Users.AddRange(users);
                context.SaveChanges();

                context.Exams.AddRange(exams);
                context.SaveChanges();

                context.Questions.AddRange(questions);
                context.SaveChanges();

                context.Answers.AddRange(answers);
                context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
