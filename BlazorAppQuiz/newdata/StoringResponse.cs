using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BlazorAppQuiz.newdata
{
    public class StoringResponse
    {
        // Method to save quiz result data to a JSON file
        public void SaveResultToFile(Result result, string filePath = null)
        {
            // Convert the result object to a JSON string
            string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);

            // Define the file path if not provided
            if (filePath == null)
            {
                filePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "response.json"
                );
            }

            // Save the JSON data to the file
            File.WriteAllText(filePath, jsonResult);

            Console.WriteLine($"Data successfully written to {filePath}");
        }
    }

    // Sample usage (this can be called from your Blazor page):
    public class QuizHandler
    {
        private readonly StoringResponse _storingResponse = new StoringResponse();

        public void SaveQuizResults()
        {
            // Sample data (you would replace this with actual user data from the quiz)
            var result = new Result
            {
                Selections = new List<UserSelections>
                {
                    new UserSelections
                    {
                        CategoryName = "Math",
                        Question = "What is 2 + 2?",
                        SelectedOption = "4",
                        Weight = 5
                    },
                    new UserSelections
                    {
                        CategoryName = "Science",
                        Question = "What planet is known as the Red Planet?",
                        SelectedOption = "Mars",
                        Weight = 5
                    }
                },
                TotalWeight = 10,
                CategoryWeights = new Dictionary<string, int>
                {
                    { "Math", 5 },
                    { "Science", 5 }
                }
            };

            // Save the quiz result to the specified file
            _storingResponse.SaveResultToFile(result, @"C:\Users\HP\source\JsonWeb\Solution2JsonWeb\BlazorAppQuiz\newdata\Response.json");
        }
    }
}
