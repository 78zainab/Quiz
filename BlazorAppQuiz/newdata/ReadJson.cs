using System.Collections.Generic;
using System.IO;
using BlazorAppQuiz.newdata;
using Newtonsoft.Json;

namespace BlazorAppQuiz.newdata
{
    public class ReadJson
    {
        // Method to get the categories and questions
        public List<Category> GetQuestions()
        {
            // Read the JSON file content
            var jsonNewData = File.ReadAllText("newdata/mitquestions.json");

            if (string.IsNullOrWhiteSpace(jsonNewData))
            {
                Console.WriteLine("JSON data is null or empty.");
                return new List<Category>();
            }

            try
            {
                // Deserialize the JSON into the CategoriesRoot object
                var root = JsonConvert.DeserializeObject<CategoriesRoot>(jsonNewData);

                if (root?.Categories == null || root.Categories.Count == 0)
                {
                    Console.WriteLine("No categories found in the JSON.");
                    return new List<Category>();
                }

                Console.WriteLine($"Deserialized {root.Categories.Count} categories.");

                // Return the list of categories
                return root.Categories;
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error deserializing JSON: " + ex.Message);
                return new List<Category>();
            }
        }
    }
}
