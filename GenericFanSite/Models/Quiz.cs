namespace GenericFanSite.Models
{
    public class Quiz
    {
        private List<Question> _questions = new List<Question>();
        public Quiz()
        {
            _questions.Add( new Question() { Q = "What is a fish?", A = "Yummy."});
            _questions.Add( new Question() { Q = "Why is a fish?", A = "He not know." });
        }
        public List<Question> Questions
        {
            get
            {
                return _questions;
            }
        }
        public bool checkAnswer(Question q)
        {
            return (q.UserA == q.A);
        }
    }
}
