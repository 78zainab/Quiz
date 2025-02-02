using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessHandler;
using EntitiesLayer;

namespace BusinessLogicProcessor
{
    public class QuestionProcessor
    {
            private readonly JsonFileHandling _jsonFileHandler;

            public QuestionProcessor(JsonFileHandling jsonFileHandler)
            {
                _jsonFileHandler = jsonFileHandler;
            }

            public List<Question> GetQuestions()
            {
                return _jsonFileHandler.LoadQuestions();
            }

            public int CalculateWeight(Dictionary<string, string> userResponses, List<Question> questions)
            {
                int totalWeight = 0;

                foreach (var response in userResponses)
                {
                    var question = questions.Find(q => q.QuestionText == response.Key);
                    var option = question?.Options?.Find(o => o.Text == response.Value);
                    if (option != null)
                    {
                        totalWeight += option.Weight;
                    }
                }

                return totalWeight;
            }
        }

}
