using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using EntitiesLayer;
using DataAccessHandler;

namespace DataAccessHandler
{
    public class JsonFileHandling
    {
        public readonly string _filePath;
        public JsonFileHandling(string filePath)
        {
            // Adjust the file path if necessary to make it absolute
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
        }

        // Method to load questions using StreamReader and Newtonsoft.Json
   public List<Question> LoadQuestions()
{
    //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "data", "questions.json");

    if (File.Exists(_filePath))
    {
        using (StreamReader reader = new StreamReader(_filePath))
                {
            string json = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Question>>(json)!;
        }
    }
    else
    {
        // Handle the case when the file doesn't exist
        return new List<Question>();
    }
}
        // Method to save result using StreamWriter and Newtonsoft.Json
        public void SaveResult(Result result)
        {
            string jsonString = JsonConvert.SerializeObject(result, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                writer.Write(jsonString);
            }
        }
    }
}

