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
            Assert.True(quiz.checkAnswer(quiz.Questions[0]));
        }
        [Fact]
        public void checkIncorrectAnswer()
        {
            Assert.False(quiz.checkAnswer(quiz.Questions[1]));
        }
        [Fact]
        public void checkNumberQuestions()
        {
            Assert.Equal(2, quiz.Questions.Count);
        }
    }
}