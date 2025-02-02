using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace BlazorAppNew.NewFolder
{
    public class Writing
    {
        public static void Main()
        {
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

            // Call the method to write the result to a JSON file
            WriteResultToJsonFile(result);
        }

        public static void WriteResultToJsonFile(Result result)
        {
            // Convert the result object to a JSON string
            string jsonResult = JsonConvert.SerializeObject(result);

            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "save.json"
            );

            // Save the JSON data to the file
            File.WriteAllText(filePath, jsonResult);

            Console.WriteLine($"Data successfully written to {filePath}");
        }
    }

  
}