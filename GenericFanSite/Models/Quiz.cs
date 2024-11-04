//I'm just putting this here so I can re-use it in a different program.
//TODO: Don't publish this class.

namespace GenericFanSite.Models
{
    public class Quiz
    {
        private List<Question> _questions = new List<Question>();
        public List<Question> Questions {
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
