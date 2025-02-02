using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TestProect.newdata
{
    public class ReadJson
    {
        public List<Questions> GetQuestions()
        {
            var jsonNewData = File.ReadAllText("newdata/newquestions.json");

            if (string.IsNullOrWhiteSpace(jsonNewData))
            {
                Console.WriteLine("JSON data is null or empty.");
                return new List<Questions>();
            }

            try
            {
                // Deserialize the JSON into an intermediate wrapper object
                var root = JsonConvert.DeserializeObject<QuestionsWrapper>(jsonNewData);

                // If the wrapper or questions list is null, return an empty list
                if (root?.Questions == null)
                {
                    Console.WriteLine("Deserialization returned null or empty questions.");
                    return new List<Questions>();
                }

                Console.WriteLine($"Deserialized {root.Questions.Count} questions.");
                //Console.WriteLine($"Deserialized {root.Questions.} questions.");

                return root.Questions;
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error deserializing JSON: " + ex.Message);
                return new List<Questions>();
            }
        }
    }

    // Add a wrapper class to match the JSON structure
    public class QuestionsWrapper
    {
        public List<Questions> Questions { get; set; }
    }
}
