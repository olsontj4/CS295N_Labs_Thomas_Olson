using GenericFanSite.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        Quiz quiz = new Quiz();
        public UnitTest1()
        {
            //Arrange
            Question q1 = new Question() { Q = "What did Thomas eat for breakfast?", A = "Cereal", UserA = "Cereal" };
            Question q2 = new Question() { Q = "What did Thomas eat for breakfast?", A = "Cereal", UserA = "Toast" };
            quiz.Questions.Add(q1);
            quiz.Questions.Add(q2);
        }
        [Fact]
        public void checkCorrectAnswer()
        {
            //Act
            //Assert
            Assert.True(quiz.CheckAnswer(quiz.Questions[2]));
        }
        [Fact]
        public void checkIncorrectAnswer()
        {
            Assert.False(quiz.CheckAnswer(quiz.Questions[3]));
        }
        [Fact]
        public void checkNumberQuestions()
        {
            Assert.Equal(4, quiz.Questions.Count);
        }
    }
}